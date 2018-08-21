using System;
using System.Collections.Generic;
using System.Text;


namespace NDT
{
    class PlayerController
    {
        private List<Player> players;

        public PlayerView playerView;

        public PlayerController(int numberLenght, int quantityOfPlayers)
        {
            this.playerView = new PlayerView();

            String[] names = new String[quantityOfPlayers];
            this.playerView.RegisterUsers(quantityOfPlayers).CopyTo(names, 0);
        }

    }
}
