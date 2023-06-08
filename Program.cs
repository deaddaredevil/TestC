using System.Net.Http.Headers;

namespace test
{
    class Program
    {
        static void Main()
        {
            int startCycle = 5;
            int endCycle = 100;
            int stepCycle = 7;

            for (int i = startCycle; i < endCycle; i += stepCycle)
            {
                Console.Write(i + " ");
            } 
            //Данный цикл выбран потому что мы знаем конечную точку и шаг, в отличии от while где неизвестно колличество цикла.
        }
    }
}