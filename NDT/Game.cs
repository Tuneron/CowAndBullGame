using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    class Game
    {
        private delegate int[] generateNumber(int lenght);

        private Random rnd;

        public int QuantityOfPlayers { get; set; }

        public int NumberLenght { get; set; }

        public int TableProportions { get; set; }

        private int[,] numbers;

        public Game(int numberLenght, int quantityOfPlayers)
        {
            this.rnd = new Random();

            this.NumberLenght = numberLenght;
            this.QuantityOfPlayers = quantityOfPlayers;

            this.numbers = new int[this.QuantityOfPlayers, this.NumberLenght];
        }

        private int[] GenerateNumbers()
        {
            generateNumber randomNumber = lenght =>
            {
                int[] number = new int[this.NumberLenght];
                for (int i = 0; i < this.NumberLenght; i++)
                    number[i] = rnd.Next(0, 10);
                return number;
            };

            return randomNumber(this.NumberLenght);
        }

        public void SetProportions(String[] PlayerNames)
        {
            int max = 0;

            for (int i = 0; i < PlayerNames.Length; i++)
            {
                if (max < PlayerNames[i].Length)
                    max = PlayerNames[i].Length;
            }

            if (max >= this.NumberLenght)
                this.TableProportions = max;
            else
                this.TableProportions = this.NumberLenght;
        }

        public void start()
        {
            for (int i = 0; i < this.QuantityOfPlayers; i++)
            {
                int[] number = new int[NumberLenght];
                number = GenerateNumbers();

                for (int j = 0; j < NumberLenght; j++)
                {
                    this.numbers[i, j] = number[j];
                }
            }
        }
    }
}
