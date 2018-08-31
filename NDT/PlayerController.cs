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
            String[] names = new String[this.Players.Count];
            for (int i = 0; i < this.Players.Count; i++)
            {
                names[i] = Players[i].Name;
            }
            return names;
        }

        public int[] GetPlayerPlaces()
        {
            int[] places = new int[Players.Count];
            for (int i = 0; i < this.Players.Count; i++)
                places[i] = Players[i].Place;
            return places;
        }

        public int[,] GetPlayerNumbers(int numberlenght)
        {
            int[,] data = new int[Players.Count, numberlenght];

            for (int i = 0; i < this.Players.Count; i++)
            {
                for (int j = 0; j < numberlenght; j++)
                {
                    data[i, j] = this.Players[i].GetNumeric(j);
                }
            }

            return data;
        }

        public void PlayersTurn(int parameterLenght, int proportions)
        {
            foreach (Player i in this.Players)
                if (i.Place == 0)
                i.Number = i.NumberToArray(playerView.EnterNumber(parameterLenght, proportions, i.Name));
        }

        public void Start()
        {
            foreach (Player i in this.Players)
                i.GenerateNumber();
        }

        public void SetPlayersPlace(int[] value)
        {
            for (int i = 0; i < this.Players.Count; i++)
                this.Players[i].Place = value[i];

        }
    }
}
