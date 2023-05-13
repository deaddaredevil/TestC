﻿namespace test
{
    class Program
    {
        static void Main()
        {
            string name;
            string singZodiac;
            int age;
            Console.Write("Ввудите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Какой ваш знак зодиака: ");
            singZodiac = Console.ReadLine();
            Console.Write("Сколько вам полных лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            string profession;
            Console.Write("Кем вы работаете:");
            profession = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, вас зовут {name}, вам {age} год, вы {singZodiac}, ваша професия {profession}!");
        }
    }
}