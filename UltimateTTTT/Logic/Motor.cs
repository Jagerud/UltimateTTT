using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTTTT.Entities;
using UltimateTTTT.Logic.Entities;

namespace UltimateTTTT.Logic
{
    class Motor
    {
        //not sure about variables
        private Board board;
        private Rules rules;
        private Position position;
        private Boolean worldEnder = false; //Ends the world as we know it!

        //private Position position = new Position();

        public Motor(Board board, Rules rules, Position position)
        {
            this.board = board;
            this.rules = rules;
            this.position = position;
        }

        public void RunGame(Square squarePos, int blockPos, Player player)
        {
            int playerPos = 0;
            int counter = 0;
            while (!worldEnder)
            {
                while (!Move(squarePos, blockPos, player)) ;


                if (counter%2 == 0)
                {
                    playerPos++;
                }
                else
                {
                    playerPos--;
                }
                counter++;
            }
        }


        public Boolean Move(Square square, int blockPos, Player player)
        {
            position.SetPosition(square, blockPos);
            while (!rules.Available(position.GetSquarePosition().getBlock(position.GetBlockPosition())))
            {
                position.SetPosition(square, blockPos);
            }
            position.GetSquarePosition().getBlock(position.GetBlockPosition()).SetOwner(player);
            //check if winner
            if (rules.Winner(position.GetSquarePosition(), player))
            {
                WonGame(player);
            }
            return true;
        }

        /**
         * Call this method when a player wins
         *
         */

        public void WonGame(Player player)
        {
            System.Console.WriteLine("Player: " + player.PlayerNumber + " won!");
                //temporary before graphical UI
            worldEnder = true;
        }
    }
}
