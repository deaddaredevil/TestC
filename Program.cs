using System.Net.Http.Headers;

namespace test
{
    class Program
    {
        static void Main()
        {
            string password = "QW1234er";
            int numberOfAttempts = 3;
            string userInput;

            Console.WriteLine("Добро пожаловать на платформу!");

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Добро пожаловать на аккаунт");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка. Пароль неверный.");
                    Console.WriteLine("У вас осталось " + (numberOfAttempts - (i + 1)));
                }
            }
        }
    }
}