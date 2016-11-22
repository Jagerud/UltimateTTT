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
        private Square[] squares;
        private Player[] players;

        public Board(Square[] squares, Player[] players)
        {
            this.squares = squares;
            this.players = players;
        }

        public Square GetSquare(int squarePos)
        {
            return squares[squarePos];
        }
        public Player GetPlayers(int playerPos)
        {
            return players[playerPos];
        }
    }
}
