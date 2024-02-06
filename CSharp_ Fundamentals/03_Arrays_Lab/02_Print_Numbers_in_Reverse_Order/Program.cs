namespace _02_Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double[] numbers = new double[number];
            for (int i = 0; i <= number - 1; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            for (int i = number - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
