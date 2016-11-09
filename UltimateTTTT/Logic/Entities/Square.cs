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
       
        public Square(Block[] blocks)
        {
            this.blocks = blocks;
        }

        //ArrayList blockList = new ArrayList();
        //Block block0 = null;
        //Block block1 = null;
        private Block[] blocks;

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
