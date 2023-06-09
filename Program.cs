using System.Net.Http.Headers;

namespace test
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 100;
            int number = random.Next(minNumber, maxNumber + 1);
            int divisorNumber1 = 3;
            int divisorNumber2 = 5;
            int sumNumbers = number;

            Console.WriteLine("начальное число " + number);

            for (int i = 0; i < number; ++i)
            {
                if (i % divisorNumber1 == 0 || i % divisorNumber2 == 0)
                {
                    sumNumbers += i;
                    Console.WriteLine(sumNumbers);
                }
                else
                {
                    continue;
                }
            }

        }
    }
}