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

        public void RunGame(int squarePos, int blockPos)
        {
            int playerPos = 0;
            int counter = 0;
            while (!worldEnder)
            {
                while (!Move(squarePos, blockPos, playerPos)) ;


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


        public Boolean Move(int squarePos, int blockPos, int playerPos)
        {
            position.SetPosition(squarePos, blockPos);
            while (!rules.Available(board.GetSquare(position.GetSquarePosition()).getBlock(position.GetBlockPosition())))
            {
                position.SetPosition(squarePos, blockPos);
            }
            board.GetSquare(position.GetSquarePosition()).getBlock(position.GetBlockPosition()).SetOwner(board.GetPlayers(playerPos));
            //check if winner
            if (rules.Winner(board.GetSquare(position.GetSquarePosition()), board.GetPlayers(playerPos)))
            {
                WonGame(playerPos);
            }
            return true;
        }

        /**
         * Call this method when a player wins
         *
         */

        public void WonGame(int playerPos)
        {
            System.Console.WriteLine("Player: " + board.GetPlayers(playerPos).PlayerNumber + " won!");
                //temporary before graphical UI
            worldEnder = true;
        }
    }
}
