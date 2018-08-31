using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{

    class Player
    {
        private Random rnd;

        public String Name;

        public int[] Number;

        public int Place { get; set; }

        public int GetNumeric(int count) { return this.Number[count]; }

        public Player(String name, int numberLenght)
        {
            this.Number = new int[numberLenght];
            this.Name = name;
            this.rnd = new Random();
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

        public void GenerateNumber()
        {
            for (int i = 0; i < this.Number.Length; i++)
                this.Number[i] = rnd.Next(0, 10);

            while (UniqueChek(this.Number) == false)
                for (int i = 0; i < this.Number.Length; i++)
                    this.Number[i] = rnd.Next(0, 10);
        }

        public String SayNumber()
        {
            convertAnswer answer = (s1, i1) =>
            {
                String line = "Player " + s1 + " has number ";
                for (int i = 0; i < i1.Length; i++)
                    line += i1[i];
                return line;
            };

            return answer(this.Name, this.Number);
        }

        public int[] NumberToArray(int number)
        {
            String tmp = number.ToString();
            int[] result = new int[tmp.Length];

            for (int i = 0; i < tmp.Length; i++)
                result[i] = int.Parse(tmp[i].ToString());

            return result;
        }
    }
}
