using System.Security.Cryptography.X509Certificates;

namespace _01_Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());
            if (1<=input && input<=7)
            {
                Console.WriteLine(days[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
