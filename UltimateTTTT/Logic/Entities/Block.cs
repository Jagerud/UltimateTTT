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
        private int owner = 0;
        private int tempCounter;

        public Blocks()
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
