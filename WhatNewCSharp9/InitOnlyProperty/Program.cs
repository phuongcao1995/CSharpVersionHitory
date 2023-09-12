namespace InitOnlyProperty
{
    public class Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                FirstName = "Drake",
                LastName = "Cao"
            };

            person = new Person()
            {
                FirstName = "Petter",
                LastName = "Cao"
            };

            // person.FirstName = "Petter";   // error

            Console.WriteLine($"{person.FirstName} {person.LastName}");

            Console.ReadKey();
        }
    }
}