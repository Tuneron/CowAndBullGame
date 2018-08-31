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

        private int PlayersPlaceCounter { get; set; }

        private int[,] numbers;

        public Game(int numberLenght, int quantityOfPlayers)
        {
            this.rnd = new Random();

            this.NumberLenght = numberLenght;
            this.QuantityOfPlayers = quantityOfPlayers;
            this.PlayersPlaceCounter = 0;

            this.numbers = new int[this.QuantityOfPlayers, this.NumberLenght];
        }

        private bool UniqueChek(int[] value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                for (int j = i + 1; j < value.Length; j++)
                {
                    if (value[j] == value[i])
                        return false;
                }
            }
            return true;
        }

        private int[] GenerateNumbers()
        {
            generateNumber randomNumber = lenght =>
            {
                int[] localNumber = new int[lenght];
                for (int i = 0; i < lenght; i++)
                    localNumber[i] = rnd.Next(0, 10);

                return localNumber;
            };

            int[] number = new int[this.NumberLenght];
            randomNumber(this.NumberLenght).CopyTo(number, 0);

            while (UniqueChek(number) == false)
                randomNumber(this.NumberLenght).CopyTo(number, 0);

            return number;
        }

        public void SetProportions(String[] PlayerNames)
        {
            int max = 16;

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

        private int InPlace(int[] number, int count)
        {
            int inPlace = 0;

            for (int i = 0; i < this.NumberLenght; i++)
            {
                if (number[i] == this.numbers[count, i])
                    inPlace++;
            }
            return inPlace;
        }

        private int OutOfPlace(int[] number, int count)
        {
            int outOfPlace = 0;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[i] == this.numbers[count, j] && i != j)
                        outOfPlace++;
                }
            }

            return outOfPlace;
        }

        public void Start()
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

        public int[] GetInPlace (int[,] numbers)
        {
            int[] data = new int[this.QuantityOfPlayers];
            int[] number = new int[this.NumberLenght];

            for (int i = 0; i < QuantityOfPlayers; i++)
            {
                for (int j = 0; j < NumberLenght; j++)
                {
                    number[j] = numbers[i, j];
                }
                data[i] = InPlace(number, i);
            }
            return data;
        }

        public int[] GetOutOfPlace(int[,] numbers)
        {
            int[] data = new int[this.QuantityOfPlayers];
            int[] number = new int[this.NumberLenght];

            for (int i = 0; i < QuantityOfPlayers; i++)
            {
                for (int j = 0; j < NumberLenght; j++)
                    number[j] = numbers[i, j];

                data[i] = OutOfPlace(number, i);
            }

            return data;
        }

        public int[] AwardingAPlace(int[] results, int[] places)
        {
            for (int i = 0; i < this.QuantityOfPlayers; i++)
                if (results[i] == this.NumberLenght && places[i] == 0)
                {
                    this.PlayersPlaceCounter++;
                    places[i] = this.PlayersPlaceCounter;
                }

            return places;
        }

        public bool EndGame()
        {
            if (this.PlayersPlaceCounter == this.QuantityOfPlayers)
                return true;
            else
                return false;
        }
    }
}
