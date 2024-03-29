﻿namespace _10_Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = lostGamesCount / 2;
            int trashedMouses = lostGamesCount / 3;
            int trashedKeyboards = lostGamesCount / 6;
            int trashedDisplays = trashedKeyboards / 2;

            double totalExpenses = (trashedHeadsets * headsetPrice) +
                                   (trashedMouses * mousePrice) +
                                   (trashedKeyboards * keyboardPrice) +
                                   (trashedDisplays * displayPrice);

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
        
    }
}
