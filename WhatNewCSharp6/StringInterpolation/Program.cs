namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Petter";
            var lastName = "Cao";
            var fullName = $"Your full name is {firstName} {lastName}";

            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}