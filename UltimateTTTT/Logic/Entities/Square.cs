using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    class Square
    {
        private Blocks[] blocks;
        private Boolean locked = false;
        public Square(Blocks[] blocks)
        {
            this.blocks = blocks;
        }

        public void SetLocked(Boolean locked)
        {
            this.locked = locked;
        }

        public Boolean GetLocked()
        {
            return locked;
        }

        public Blocks[] Blocks { get; set; }

        //ArrayList blockList = new ArrayList();
        //Blocks block0 = null;
        //Blocks block1 = null;
        

        /*public void BlockArrayBuilder()
        {
            blockList.Add(block0);
            blockList.Add(block1);
        }
        public ArrayList getBlockList()
        {
            return blockList;
        }
        */
    }
}
