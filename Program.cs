using System.Net.Http.Headers;

namespace test
{
    class Program
    {
        static void Main()
        {
            string theFinalWord = "exit";
            string userImrut;
            for(int i = 1; i > 0; i++)
            {
                Console.Write("Введите слово завершающие цикл: ");
                userImrut = Console.ReadLine();
                if (userImrut == theFinalWord)
                {
                    Console.WriteLine("Завершаем цикл!");
                    break;
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}