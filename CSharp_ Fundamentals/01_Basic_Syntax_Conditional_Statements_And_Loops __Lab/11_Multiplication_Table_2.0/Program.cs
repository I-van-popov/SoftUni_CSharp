namespace _11_Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            if (x <= 10)
            {
                for (int i = x; i <= 10; i++)
                {
                    int product = n * i;
                    Console.WriteLine($"{n} X {i} = {product}");
                }
            }
            else
            {
                int product = n * x;
                Console.WriteLine($"{n} X {x} = {product}");
            }
        }
    }
}
