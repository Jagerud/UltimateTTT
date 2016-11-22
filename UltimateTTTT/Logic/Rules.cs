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
            return square.getBlock(0).GetOwner() == 0;    //0 = Available
        }

        public void Winner(Square square, Player player)
        {
            //3 in row horisontal

                for (int i = 0; i < 9; i = i + 3)
                {

                    if (square.getBlock(i).GetOwner() == player.PlayerNumber &&
                        square.getBlock(i + 1).GetOwner() == player.PlayerNumber &&
                        square.getBlock(i + 2).GetOwner() == player.PlayerNumber)
                    {
                        //Player  wins this square
                        WonGame(player);
                    }
                }
                //3 in row vertical
                for (int i = 0; i < 3; i++)
                {
                    if (square.getBlock(i).GetOwner() == player.PlayerNumber &&
                        square.getBlock(i + 3).GetOwner() == player.PlayerNumber &&
                        square.getBlock(i + 6).GetOwner() == player.PlayerNumber)
                    {
                        //Player  wins this square
                        WonGame(player);
                    }
                }
                //3 in row diagonally
                if (square.getBlock(0).GetOwner() == player.PlayerNumber &&
                    square.getBlock(4).GetOwner() == player.PlayerNumber &&
                    square.getBlock(8).GetOwner() == player.PlayerNumber)
                {
                    //Player  wins this square
                    WonGame(player);
                }
                if (square.getBlock(2).GetOwner() == player.PlayerNumber &&
                    square.getBlock(4).GetOwner() == player.PlayerNumber &&
                    square.getBlock(6).GetOwner() == player.PlayerNumber)
                {
                    //Player 1 wins this square
                    WonGame(player);
                }


        }

        public Boolean SquareFull(Square square)
        {
            Boolean full = true;
            for (int i = 0; i < 9; i++)
            {
                if (square.getBlock(i).GetOwner() == 0)
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
                    board.GetSquare(i).SetLockedState(true);
                }
            }
        }
        /**
         * Call this method when a player wins
         * 
         */
        public void WonGame(Player player)
        {
            System.Console.WriteLine("Player: " + player.PlayerNumber + " won!");        //temporary before graphical UI
            System.Environment.Exit(1);
        }
    }
}
