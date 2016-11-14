using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    
    class Blocks
    {
        //private Player owner ;
        private int owner;
        public void setOwner(Player owner)
        {
            
            this.owner = owner.PlayerNumber;
            
        }
        public int getOwner()
        {
            return owner;
        }
    }
}
