﻿namespace _02_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int divisible = -1;

            if (number % 10 == 0)
            {
                divisible = 10;
            }
            else if (number % 7 == 0)
            {
                divisible = 7;
            }
            else if (number % 6 == 0)
            {
                divisible = 6;
            }
            else if (number % 3 == 0)
            {
                divisible = 3;
            }
            else if (number % 2 == 0)
            {
                divisible = 2;
            }
            if (di!= -1)
            {
                Console.WriteLine($"The number is divisible by {divisible}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
