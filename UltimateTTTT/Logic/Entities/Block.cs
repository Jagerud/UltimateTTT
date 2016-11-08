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
            this.owner = owner;
        }
        public int getOwner()
        {
            return owner;
        }
    }
}
