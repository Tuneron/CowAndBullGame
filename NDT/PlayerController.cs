using System;
using System.Collections.Generic;
using System.Text;


namespace NDT
{
    class PlayerController
    {
        private List<Player> Players;

        public PlayerView playerView;

        public PlayerController(int numberLenght, int quantityOfPlayers)
        {
            this.playerView = new PlayerView();

            String[] names = new String[quantityOfPlayers];
            this.playerView.RegisterUsers(quantityOfPlayers).CopyTo(names, 0);

            this.Players = new List<Player>();

            for (int i = 0; i < quantityOfPlayers; i++)
            {
                this.Players.Add(new Player(names[i], numberLenght));
            }
        }

        public String[] GetPlayerNames()
        {
            String[] names = new String[Players.ToArray().Length];
            for (int i = 0; i < this.Players.Capacity; i++)
            {
                names[i] = Players[i].Name;
                //Console.WriteLine(names[i]);
            }
            return names;
        }

        public int[] GetPlayerPlaces()
        {
            int[] places = new int[Players.Capacity];
            for (int i = 0; i < this.Players.Capacity; i++)
                places[i] = Players[i].Place;
            return places;
        }

    }
}
