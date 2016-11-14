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
        //If block is free
        public Boolean Available(Position position, Square square)
        {
            return square.Blocks[0].getOwner() == 0;    //0 = Available
        }

        public void Winner(Square square, Player[] players)
        {
            //3 in row horisontal

            for (int j = 0; j < 2; j++)
            {


                for (int i = 0; i < 9; i = i + 3)
                {

                    if (square.Blocks[i].getOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 1].getOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 2].getOwner() == players[j].PlayerNumber)
                    {
                        //Player 1 wins this square
                    }


                }
                //3 in row vertical
                for (int i = 0; i < 3; i++)
                {
                    if (square.Blocks[i].getOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 3].getOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 6].getOwner() == players[j].PlayerNumber)
                    {
                        //Player 1 wins this square
                    }
                }
                //3 in row diagonally
                if (square.Blocks[0].getOwner() == players[j].PlayerNumber &&
                    square.Blocks[4].getOwner() == players[j].PlayerNumber &&
                    square.Blocks[8].getOwner() == players[j].PlayerNumber)
                {
                    //Player 1 wins this square
                }
                if (square.Blocks[2].getOwner() == players[j].PlayerNumber &&
                    square.Blocks[4].getOwner() == players[j].PlayerNumber &&
                    square.Blocks[6].getOwner() == players[j].PlayerNumber)
                {
                    //Player 1 wins this square
                }
            }

        }
    }
}
