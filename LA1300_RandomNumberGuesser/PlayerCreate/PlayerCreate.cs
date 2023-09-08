using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LA1300_RandomNumberGuesser.GenerateNumber;


namespace LA1300_RandomNumberGuesser.Player
{
    internal class PlayerCreate
    {
        private string playerName;
        private int playerId;

        public string PlayerName
        {
            get
            {
                return "Spieler " + playerName;
            }

        }
        public PlayerCreate(string playerName)
        {
            this.playerName = playerName;
        }

    }
}
