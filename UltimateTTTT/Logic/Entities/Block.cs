using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    
    class Blocks
    {
        private Player owner ;

        public void setOwner(Player owner)
        {
            if (owner.PlayerNumber < 3)
            {
                this.owner = owner;
            }
            else
            {
                System.Console.WriteLine("Wrong input, should be 0-2");
            }
        }
        public Player getOwner()
        {
            return owner;
        }
    }
}
