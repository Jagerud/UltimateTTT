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
        public void SetOwner(Player owner)
        {
            
            this.owner = owner.PlayerNumber;
            
        }
        public int GetOwner()
        {
            return owner;
        }
    }
}
