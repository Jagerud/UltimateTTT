using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    
    class Blocks
    {
        private int owner = 0;

        public void setOwner(int owner)
        {
            if (owner < 3)
            {
                this.owner = owner;
            }
            else
            {
                System.Console.WriteLine("Wrong input, should be 0-2");
            }
        }
        public int getOwner()
        {
            return owner;
        }
    }
}
