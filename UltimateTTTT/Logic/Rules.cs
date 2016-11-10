using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using UltimateTTTT.Entities;
using UltimateTTTT.Logic.Entities;

namespace UltimateTTTT.Logic
{
    class Rules
    {
        //Facade facade = new Facade(); 
        public void LockedSquare(Position position)
        {


            if (position.GetBlockPosition() == 0)
            {
                //light up square 0
                
            }
            if (position.GetBlockPosition() == 1)
            {
                //light up square 0

            }
            if (position.GetBlockPosition() == 2)
            {
                //light up square 0

            }
            if (position.GetBlockPosition() == 3)
            {
                //light up square 0

            }
            if (position.GetBlockPosition() == 4)
            {
                //light up square 0

            }
            if (position.GetBlockPosition() == 5)
            {
                //light up square 0

            }
            if (position.GetBlockPosition() == 6)
            {
                //light up square 0

            }
            if (position.GetBlockPosition() == 7)
            {
                //light up square 0

            }
            if (position.GetBlockPosition() == 8)
            {
                //light up square 0

            }
        }

        public Boolean Available(Position position, Square square)
        {
            return square.Blocks[0].getOwner().PlayerNumber == 0;    //0 = Available
        }

        public void Winner(Square square)
        {
            //3 in row horisontal
            if (square.Blocks[0].getOwner().PlayerNumber == 0)
            {
                
            }

            //3 in row vertical

            //3 in row diagonally
        }
    }
}
