namespace _07_Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = -1;

            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "weekday":
                        ticketPrice = 12;
                        break;
                    case "weekend":
                        ticketPrice = 15;
                        break;
                    case "holiday":
                        ticketPrice = 5;
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (dayType)
                {
                    case "weekday":
                        ticketPrice = 18;
                        break;
                    case "weekend":
                        ticketPrice = 20;
                        break;
                    case "holiday":
                        ticketPrice = 12;
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (dayType)
                {
                    case "weekday":
                        ticketPrice = 12;
                        break;
                    case "weekend":
                        ticketPrice = 15;
                        break;
                    case "holiday":
                        ticketPrice = 10;
                        break;
                }
            }
            if (ticketPrice != -1)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
