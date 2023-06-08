using System.Net.Http.Headers;

namespace test
{
    class Program
    {
        static void Main()
        {
            int startNumber = 5;
            int endCycle = 96;
            int stepCycle = 7;

            for (int i = startNumber; i <= endCycle; i += stepCycle)
            {
                Console.Write(i + " ");
            } 
        }
    }
}