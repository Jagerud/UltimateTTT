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
        private Position position = new Position();

        public Motor(Board board)
        {
            this.board= board;
        }

        public void Move(Position position, Player player)
        {
            if (board.GetSquare()[position.GetSquarePosition()].Blocks[position.GetBlockPosition()].getOwner() == 0)
                //free
            {
                board.GetSquare()[position.GetSquarePosition()].Blocks[position.GetBlockPosition()].setOwner(player);
                    //player as owner
            }
            else
            {
                //block 
            }
            //check if winner
            rules.Winner(board.GetSquare()[position.GetSquarePosition()], board.GetPlayers());

        }

    }
}
