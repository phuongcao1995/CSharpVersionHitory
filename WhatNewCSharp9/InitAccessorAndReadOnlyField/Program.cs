namespace InitAccessorAndReadOnlyField
{
    public class Person
    {
        private readonly string firstName = "<unknown>";
        private readonly string lastName = "<unknown>";

        public string FirstName
        {
            get => firstName;
            init => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            init => lastName = value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            var person = new Person()
            {
                //FirstName = "Drake",
                //LastName = "Cao"
            };

            Console.WriteLine($"{person.FirstName} {person.LastName}");

            Console.ReadKey();
        }
    }
}