namespace _04_Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            while (startNumber != endNumber+1)
            {
                Console.Write(startNumber+" ");
                sum += startNumber;
                startNumber++;
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
