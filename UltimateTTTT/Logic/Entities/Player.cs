using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateTTTT.Logic.Entities
{
    public class Player
    {
        int playerNumber;

        public Player(int playerNumber)
        {
            this.playerNumber = playerNumber;
        }

        public int PlayerNumber
        {
            get { return playerNumber; }
        }
    }
}
