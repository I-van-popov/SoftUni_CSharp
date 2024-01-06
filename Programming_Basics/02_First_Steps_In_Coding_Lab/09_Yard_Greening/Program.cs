namespace _09_Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());

            double pricePerOneM = 7.61;
            double price = yard * pricePerOneM;

            double discount = price * 0.18;

            double totalPrice = price - discount;

            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}