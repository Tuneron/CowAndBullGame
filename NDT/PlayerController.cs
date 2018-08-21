using System;
using System.Collections.Generic;
using System.Text;


namespace NDT
{
    class PlayerController
    {
        private List<Player> players;

        public PlayerController(int numberLenght, int quantityOfPlayers, String[] playerNames)
        {
            for (int i = 0; i < quantityOfPlayers; i++)
                this.players.Add(new Player(playerNames[i], numberLenght));
        }

    }
}
