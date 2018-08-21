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
            GameController gameController = new GameController();
            gameController.Run();
        }
    }
}
