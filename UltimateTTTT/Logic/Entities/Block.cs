using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    
    class Block
    {
        //private Player owner ;
        private int owner = 0;
        private int tempCounter;

        public Block()
        {
            
        }

        public void setCounter(int counter)
        {
            tempCounter = counter;
        }
        public int getCounter()
        {
            return tempCounter;
        }
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
