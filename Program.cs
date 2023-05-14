﻿namespace test
{
    class Program
    {
        static void Main()
        {
            int countPeople;
            int receptionTime = 10;
            int minutesInHour = 60;
            Console.WriteLine("Добро пожаловать в поликлинику!");
            Console.Write("Время приема составляет 10 минут, сколько перед вами людей: ");
            countPeople = Convert.ToInt32(Console.ReadLine());
            int waitingTimeMinutes = countPeople * receptionTime % minutesInHour;
            int waitingTimeHour = countPeople * receptionTime / minutesInHour;
            Console.WriteLine($"Примерное время ожидания составит {waitingTimeHour} часов и {waitingTimeMinutes} минут!");
        }
    }
}