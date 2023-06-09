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
            int number = random.Next(minNumber, maxNumber +1);
            int startNumber = number;
            int divisorNumber = 3;

            Console.WriteLine(number);

            for (int i = number; startNumber > 0; i = divisorNumber) 
            {
                number += startNumber - divisorNumber;
                startNumber-=divisorNumber;        
                Console.WriteLine(number);
            }
        }
    }
}