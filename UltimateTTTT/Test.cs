using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTTTT.Logic.Entities;

namespace UltimateTTTT
{
    class Test
    {
        static void Main(string[] args)
        {
            Block[] blocks = new Block[9];
            Square[] squares = new Square[9];
            //insert blocks
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new Block();
            }
            for (int i = 0; i < squares.Length; i++)
            {
                squares[i] = new Square(blocks);
            }
            Board board = new Board();      //insert squares
            
            
        }
    }
    //Regelboken tar emot en instans av bräde och en vad som vill göras
    //Hur saker behandlas mellan lager


}

