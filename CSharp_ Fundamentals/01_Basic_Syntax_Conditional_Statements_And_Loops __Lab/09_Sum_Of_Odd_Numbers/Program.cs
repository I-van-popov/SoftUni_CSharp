namespace _09_Sum_Of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(currentNumber);
                sum += currentNumber;
                currentNumber += 2;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
