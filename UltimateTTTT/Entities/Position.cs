using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Entities
{
    class Position
    {

        private int[] position = new int[2];
        public int[] GetPosition()
        {
            return position;
        }

        public void SetPosition(int[] position) //or send 2 values and put in position
        {
            this.position = position;
        }
    }
}
