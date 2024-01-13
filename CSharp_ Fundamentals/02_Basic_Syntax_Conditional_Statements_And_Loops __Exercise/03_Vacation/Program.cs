using System.Diagnostics;

namespace _03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceForPerson = 0.0;
            double discount = 0.0;
            double price = 0.0;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            priceForPerson = 8.45;
                            break;
                        case "Saturday":
                            priceForPerson = 9.80;
                            break;
                        case "Sunday":
                            priceForPerson = 10.46;
                            break;
                    }
                    if (numberOfPeople >= 30)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            priceForPerson = 10.90;
                            break;
                        case "Saturday":
                            priceForPerson = 15.60;
                            break;
                        case "Sunday":
                            priceForPerson = 16.00;
                            break;
                    }
                    if (numberOfPeople >= 100)
                    {
                        numberOfPeople -= 10;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            priceForPerson = 15.00;
                            break;
                        case "Saturday":
                            priceForPerson = 20.00;
                            break;
                        case "Sunday":
                            priceForPerson = 22.50;
                            break;
                    }
                    if (10<= numberOfPeople && numberOfPeople <= 20)
                    {
                        discount = 0.05;
                    }
                    break;

            }
            price = (numberOfPeople * priceForPerson) - (numberOfPeople * priceForPerson * discount);
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}