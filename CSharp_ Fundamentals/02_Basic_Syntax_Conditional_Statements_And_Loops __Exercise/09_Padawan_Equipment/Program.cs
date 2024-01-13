namespace _09_Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyJohnHas = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            int freeBelts = studentCount / 6;
            int totalBelts = studentCount - freeBelts;

            double totalCost = (priceLightsaber * Math.Ceiling(studentCount * 1.1)) +
                               (priceRobe * studentCount) +
                               (priceBelt * totalBelts);

            if (moneyJohnHas >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                double neededMoney = totalCost - moneyJohnHas;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }
        }
    }
}