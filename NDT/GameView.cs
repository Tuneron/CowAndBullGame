using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    class GameView
    {
        public GameView() {}

        public int RegisterLenghtNumber()
        {
            int NumberLenght;
            do
            {
                Console.Write("Write lenght of number (from 4 to 8) = ");
                NumberLenght = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            while (!(NumberLenght >= 4 && NumberLenght <= 8));
            Console.Clear();
            return NumberLenght; 
        }

        public int RegisterQuantityOfPlayers()
        {
            int QuantityOfPlayers;
            do
            {
                Console.Write("Write quantity of players (from 1 to 4) = ");
                QuantityOfPlayers = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            while (!(QuantityOfPlayers > 0 && QuantityOfPlayers < 5));
            Console.Clear();
            return QuantityOfPlayers;
        }

        public void Line(String symbol) {for (int i = 0; i < 120; i++) Console.Write(symbol);}
        public void Sides(String symbol, int lenght, int quantityOfPlayers)
        {
            Console.Write(symbol);
            for (int j = 0; j < quantityOfPlayers; j++)
            {
                for (int i = 0; i < lenght + 4; i++)
                    Console.Write(" ");
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        public void Parameter(int lenght, String symbol, String name, params int[] value)
        {
            int currencyLenght = lenght - name.Length - value.Length - 1;

            Console.Write("  {0} : ", name);

            for (int i = 0; i < value.Length; i++) { Console.Write("{0}", value[i]); }
            for (int i = 0; i < currencyLenght; i++) { Console.Write(" "); }
            Console.Write(symbol);
        }

        public void Head (String[] PlayerNames, int Proportions, int[] PlayerPlace)
        {
            Line("#");
            Sides("#", Proportions, PlayerNames.Length);
            Console.Write("#");
            for (int i = 0; i < PlayerNames.Length; i++)
            Parameter(Proportions, "#", PlayerNames[i], PlayerPlace[i]);
            Console.WriteLine();
        }

        public void Body(int Proportions, int[] Place, int[] InPlace, int[] OutOfPlace)
        {
            Sides("#", Proportions, Place.Length);
            Line("#");
            Sides("#", Proportions, Place.Length);
            Console.Write("#");
            for (int i = 0; i < Place.Length; i++)
                Parameter(Proportions, "#", "in place", InPlace[i]);
            Console.WriteLine();
            Console.Write("#");
            for (int i = 0; i < Place.Length; i++)
                Parameter(Proportions, "#", "out of place", OutOfPlace[i]);
            Console.WriteLine();
            Sides("#", Proportions, Place.Length);
            Line("#");
        }
    }
}
