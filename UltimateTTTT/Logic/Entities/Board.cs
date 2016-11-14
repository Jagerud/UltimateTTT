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
        //ArrayList squaresList = new ArrayList();
        private Blocks[] blocks;
        private Square[] squares;
        private Player[] players;

        public Board(Blocks[] blocks, Square[] squares, Player[] players)
        {
            this.blocks = blocks;
            this.squares = squares;
            this.players = players;
        }
        

        public Square[] GetSquare()
        {
            return squares;
        }
    }
}
