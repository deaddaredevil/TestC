using System.Net.Http.Headers;

namespace test
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int number = rand.Next(0, 101);
            int startNumber = number;
            int stepNumber = 3;

            Console.WriteLine(number);

            while (startNumber > 0)
            {
                number += startNumber - stepNumber;
                startNumber-=stepNumber;        
                Console.WriteLine(number);
            }
        }
    }
}