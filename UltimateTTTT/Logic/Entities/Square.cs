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
       
        public Square(Blocks[] blocks)
        {
            this.blocks = blocks;
        }

        //ArrayList blockList = new ArrayList();
        //Blocks block0 = null;
        //Blocks block1 = null;
        private Blocks[] blocks;

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
