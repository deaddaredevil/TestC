using System.Net.Http.Headers;

namespace test
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int initialNumber = random.Next(1,28);
            int maximumNumber = 1000;
            int minimumNumber = 99;
            int sumMultiplicityNunber = 0;
            int multipleNumber = initialNumber;

            while (multipleNumber <= maximumNumber)
            {
                multipleNumber += initialNumber;

                if (multipleNumber <= minimumNumber)
                {
                    continue;
                }

                sumMultiplicityNunber++;
            }

            Console.WriteLine($"Колличество трехзначных чисел кратных {initialNumber} будет {sumMultiplicityNunber} .");
        }
    }
}