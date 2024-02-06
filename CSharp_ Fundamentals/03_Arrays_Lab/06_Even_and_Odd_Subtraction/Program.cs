namespace _06_Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int evenSum = 0;
            int OddSum = 0;
            foreach (int i in input)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    OddSum += i;
                }
            }
            Console.WriteLine(evenSum - OddSum);
        }
    }
}
