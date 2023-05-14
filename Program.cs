﻿namespace test
{
    class Program
    {
        static void Main()
        {
            int gold;
            int crystals;
            int pricePerCrystal = 8;
            bool canPay;
            Console.WriteLine($"добро пожаловать в магазин, сегодня стоимость кристалов составляет {pricePerCrystal} золота.");
            Console.Write("сколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("сколько вы хотите купить кристалов?");
            crystals = Convert.ToInt32(Console.ReadLine());
            canPay = gold >= crystals * pricePerCrystal;
            crystals *= (Convert.ToInt32(canPay));
            gold -= crystals * pricePerCrystal;
            Console.WriteLine($"У вас осталось {gold} золота, у вас в наличии {crystals} кристалов");
        }
    }
}