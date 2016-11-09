using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    class Board
    {
        ArrayList squaresList = new ArrayList();
        Square square0 = null;
        Square square1 = null;
        public void SquareArrayBuilder()
        {
            squaresList.Add(square0);
            squaresList.Add(square1);
        }
        

        public ArrayList getSquareList()
        {
            return squaresList;
        }
    }
    //test
}
