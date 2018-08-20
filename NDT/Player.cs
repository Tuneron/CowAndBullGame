using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    
    class Player
    {
        private Random rnd;

        public String name { get; }

        private int[] number { get; set;}

        public int place { get; set; }

        public Player(String name, int numberLenght)
        {
            this.number = new int[numberLenght];
            this.name = name;
            this.rnd = new Random();

            generate_number();
        }

        private void generate_number()
        {
            for (int i = 0; i < this.number.Length; i++)
                this.number[i] = rnd.Next(0, 10);
        }

        public int[] stroke (bool[] known) {

        return new int[1];
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

            return answer(this.name, this.number);
        }
    }
}
