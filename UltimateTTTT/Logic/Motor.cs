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
            this.board= board;
            this.rules = rules;
            this.position = position;
            
        }

        public void RunGame( int squarePos, int blockPos)
        {
            
            int playerPos=0;
            int counter=0;
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
            position.SetPosition(squarePos,blockPos);
            //if free
            if (board.GetSquare(squarePos).getBlock(blockPos).GetOwner() != 0)
                return false;
            board.GetSquare(squarePos).getBlock(blockPos).SetOwner(board.GetPlayers(playerPos));
            //check if winner
            rules.Winner(board.GetSquare(squarePos), board.GetPlayers(playerPos));
            return true;
            //block
        }

    }
}
