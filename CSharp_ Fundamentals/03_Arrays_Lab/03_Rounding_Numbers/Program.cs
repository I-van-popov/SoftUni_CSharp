using System;

namespace _03_Rounding_Numbers
{
    internal class Program
    {
        static int Round(double num)
        {
            if (num < 0)
                return (int)(num - 0.5);
            else
                return (int)(num + 0.5);
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            foreach (string numberStr in input)
            {
                double number = double.Parse(numberStr);
                int roundedNumber = Round(number);
                Console.WriteLine($"{number} => {roundedNumber}");
            }
        }
    }
}
