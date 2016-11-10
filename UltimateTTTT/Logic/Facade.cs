using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTTTT.Logic.Entities;

namespace UltimateTTTT.Logic
{
    class Facade
    {
        Board board = new Board();

        public Board getBoard()
        {
            return board;
        }
    }
}
