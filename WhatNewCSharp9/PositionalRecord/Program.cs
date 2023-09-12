namespace PositionalRecord
{
    public record Person(string FirstName, string LastName);
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Drake", "Cao");
            Person person2 = person with { FirstName = "Petter" };
            Console.WriteLine(person);
            Console.WriteLine(person2);
            Console.ReadKey();
        }
    }
}