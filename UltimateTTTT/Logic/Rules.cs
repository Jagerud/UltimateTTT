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
    /**
     * Many of the methods should probably be private when finished.
     */
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
            return square.Blocks[0].GetOwner() == 0;    //0 = Available
        }

        public void Winner(Square square, Player[] players)
        {
            //3 in row horisontal

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 9; i = i + 3)
                {

                    if (square.Blocks[i].GetOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 1].GetOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 2].GetOwner() == players[j].PlayerNumber)
                    {
                        //Player  wins this square
                        WonGame(players[j]);
                    }
                }
                //3 in row vertical
                for (int i = 0; i < 3; i++)
                {
                    if (square.Blocks[i].GetOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 3].GetOwner() == players[j].PlayerNumber &&
                        square.Blocks[i + 6].GetOwner() == players[j].PlayerNumber)
                    {
                        //Player  wins this square
                        WonGame(players[j]);
                    }
                }
                //3 in row diagonally
                if (square.Blocks[0].GetOwner() == players[j].PlayerNumber &&
                    square.Blocks[4].GetOwner() == players[j].PlayerNumber &&
                    square.Blocks[8].GetOwner() == players[j].PlayerNumber)
                {
                    //Player  wins this square
                    WonGame(players[j]);
                }
                if (square.Blocks[2].GetOwner() == players[j].PlayerNumber &&
                    square.Blocks[4].GetOwner() == players[j].PlayerNumber &&
                    square.Blocks[6].GetOwner() == players[j].PlayerNumber)
                {
                    //Player 1 wins this square
                    WonGame(players[j]);
                }
            }

        }

        public Boolean SquareFull(Square square)
        {
            Boolean full = true;
            for (int i = 0; i < 9; i++)
            {
                if (square.Blocks[i].GetOwner() == 0)
                {
                    full = false;
                }
            }
            return full;
        }

        public void LockSquares(Position position, Board board)
        {
            
            for (int i = 0; i < 9; i++)
            {
                if (position.GetBlockPosition() == i)    //change null to generic block
                {
                    //dont do much really, chill for a fraction of a second.
                }
                else
                {
                    board.GetSquare()[i].SetLockedState(true);
                }
            }
        }
        /**
         * Call this method when a player wins
         * 
         */
        public void WonGame(Player player)
        {
            System.Console.WriteLine("Player: " + player + " won!");        //temporary before graphical UI
        }
    }
}
