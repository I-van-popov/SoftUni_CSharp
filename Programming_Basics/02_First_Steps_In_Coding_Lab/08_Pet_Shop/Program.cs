namespace _08_Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.5;
            double catFoodPrice = 4.0;

            double totalSum = (dogFood * dogFoodPrice) + (catFoodPrice * catFood);
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}