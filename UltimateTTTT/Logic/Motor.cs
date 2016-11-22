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
        //private Position position = new Position();

        public Motor(Board board, Rules rules)
        {
            this.board= board;
            this.rules = rules;
        }

        public void RunGame(Position position, int squarePos, int blockPos, Player player)
        {
            int playerPos=0;
            int counter=0;
            while (true)
            {
                Move(position, squarePos, blockPos, player);
                
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

        
        public Boolean Move(Position position, int squarePos, int blockPos, Player player)
        {
            position.SetPosition(squarePos,blockPos);
            //if free
            if (board.GetSquare(squarePos).getBlock(blockPos).GetOwner() != 0)
                return false;
            board.GetSquare(squarePos).getBlock(blockPos).SetOwner(player);
            //check if winner
            rules.Winner(board.GetSquare(squarePos), player);
            return true;
            //block
        }

    }
}
