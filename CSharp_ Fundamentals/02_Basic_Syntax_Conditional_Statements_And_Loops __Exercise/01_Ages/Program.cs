namespace _1_Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string type = "";
            if (0 <= age && age <= 2)
            {
                type = "baby";

            }
            else if (3 <= age && age <= 13)
            {
                type = "child";
            }
            else if (14 <= age && age <= 19)
            {
                type = "teenager";
            }
            else if (20 <= age && age <= 65)
            {
                type = "adult";
            }
            else if (65 <= age)
            {
                type = "elder";
            }
            Console.WriteLine(type);
        }
    }
}
