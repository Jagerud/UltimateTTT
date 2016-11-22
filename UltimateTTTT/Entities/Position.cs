using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Entities
{
    class Position
    {
        //A square and a block in that square
        private int[] position = new int[2];
        public int[] GetPosition()
        {
            return position;
        }
        public void SetPosition(int square,int block) //or send 2 values and put in position
        {
            position[0] = square;
            position[1] = block;
        }
        public int GetSquarePosition()
        {
            return position[0];
        }
        public int GetBlockPosition()
        {
            return position[1];
        }
    }
}
