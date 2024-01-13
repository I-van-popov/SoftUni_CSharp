using System;

namespace _06_Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int originalNum = number;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += Factorial(digit);
                number /= 10;
            }

            if (sum == originalNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
