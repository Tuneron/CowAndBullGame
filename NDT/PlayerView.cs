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

        public int EnterNumber(int ParameterLenght, int Proportions, String name)
        {
            Console.WriteLine();
            int number = 0;

            while (number.ToString().Length != ParameterLenght)
            {
                Console.Write(" Player {0} enter your number : ", name);
                number = int.Parse(Console.ReadLine());
            }

            return number;
        }
    }
}
