using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    class Game
    {
        private delegate int[] generateNumber(int lenght);

        private Random rnd;

        public Player[] players;

        public int numberLenght;

        private int[,] numbers;

        public Game(int numberLenght, params Player[] players)
        {
            this.players = new Player[players.Length];
            players.CopyTo(this.players, 0);

            this.rnd = new Random();

            this.numberLenght = numberLenght;

            this.numbers = new int[this.players.Length, this.numberLenght];
        }

        private int[] GenerateNumber()
        {
            generateNumber randomNumber = lenght =>
            {
                int[] number = new int[this.numberLenght];
                for (int i = 0; i < this.numberLenght; i++)
                    number[i] = rnd.Next(0, 10);
                return number;
            };

            return randomNumber(this.numberLenght);
        }

        public void start()
        {
            for (int i = 0; i < this.players.Length; i++)
            {
                int[] number = new int[numberLenght];
                number = GenerateNumber();

                for (int j = 0; j < numberLenght; j++)
                {
                    this.numbers[i, j] = number[j];
                }
            }
        }
    }
}
