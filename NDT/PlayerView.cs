using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    class PlayerView
    {
        public PlayerView() {}

        public String[] RegisterUsers(int quantityOfPlayers)
        {
            String[] names = new String[quantityOfPlayers];

            for (int i = 0; i < quantityOfPlayers; i++)
            {
                Console.Write("Write name of {0} palyer : ", i + 1);
                names[i] = Console.ReadLine();
                Console.Clear();
            }
            return names;
        }
    }
}
