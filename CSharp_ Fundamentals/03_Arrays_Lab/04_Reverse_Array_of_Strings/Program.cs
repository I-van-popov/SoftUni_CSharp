namespace _04_Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] reverse = new string[input.Length];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse[(input.Length - 1) - i] = input[i];
            }
            foreach (string item in reverse)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
        }
    }
}
