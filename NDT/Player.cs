using System;
using System.Collections.Generic;
using System.Text;

namespace NDT
{
    
    class Player
    {
        private Random rnd;

        public String Name { get; }

        private int[] Number { get; set;}

        public int Place { get; set; }

        public Player(String name, int numberLenght)
        {
            this.Number = new int[numberLenght];
            this.Name = name;
            this.rnd = new Random();

            generate_number();
        }

        private void generate_number()
        {
            for (int i = 0; i < this.Number.Length; i++)
                this.Number[i] = rnd.Next(0, 10);
        }

        public int[] stroke (bool[] known) {

        return new int[0];
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
    }
}
