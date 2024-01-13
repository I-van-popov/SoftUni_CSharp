namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            var posword = Reverse(userName);
            int attempt = 0;

            while (true)
            {
                attempt++;
                string log = Console.ReadLine();

                if (attempt == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

                if (posword != log)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
            }

        }
        static string Reverse(string userName)
        {
            char[] cArray = userName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
