using System;

namespace NDT
{
    // Создадим несколько делегатов имитирующих 
    // простейшую форму регистрации
    delegate String convertAnswer(String name, int[] number);
    delegate int getMaxValue(String[] names, int lenghtNumber);

    class Program
    {
        private static void Main()
        {
            Player player1 = new Player("Daniil", 4);
            Console.WriteLine(player1.SayNumber());

            Player player2 = new Player("Anastasia", 4);
            Console.WriteLine(player2.SayNumber());

            GameView gameView = new GameView();
            gameView.Head(null, null, null);


            Game game = new Game(4, player1, player2);
            game.start();
        }
    }
}
