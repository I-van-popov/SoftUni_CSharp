namespace _01_Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName  = Console.ReadLine();
            int age  = int.Parse(Console.ReadLine());
            double AverageGrade  = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {AverageGrade :f2}");
        }
    }
}