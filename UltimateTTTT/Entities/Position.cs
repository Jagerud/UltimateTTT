using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTTTT.Logic.Entities;

namespace UltimateTTTT.Entities
{
    class Position
    {
        //A square and a block in that square
        private int blockPosition;
        private Square squarePosition;
        public int GetPosition()
        {
            return blockPosition;
        }
        public void SetPosition(Square square,int block) //or send 2 values and put in blockPosition
        {
            squarePosition = square;
            blockPosition = block;
        }
        public Square GetSquarePosition()
        {
            return squarePosition;
        }
        public int GetBlockPosition()
        {
            return blockPosition;
        }
    }
}
