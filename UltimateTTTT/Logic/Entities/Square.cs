using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace UltimateTTTT.Logic.Entities
{
    class Square
    {
        private Blocks[] blocks;
        private Boolean locked;
        public Square(Blocks[] blocks)
        {
            this.blocks = blocks;
        }

        public void SetLockedState(Boolean locked)
        {
            this.locked = locked;
        }

        public Boolean GetLocked()
        {
            return locked;
        }

        //public getBlock getBlock { get ; set; }

        public Blocks getBlock(int blockPos)
        {
            return blocks[blockPos];
        }

        public void setBlock(Block block)
        {

        }

        //ArrayList blockList = new ArrayList();
        //getBlock block0 = null;
        //getBlock block1 = null;
        

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
