using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    
    class Block
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
                
            }
        }
        public int getOwner()
        {
            return owner;
        }
    }
}
