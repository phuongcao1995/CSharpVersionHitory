namespace RecordType
{
    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person()
            {
                FirstName = "Drake",
                LastName = "Cao"
            };

            var person2 = new Person()
            {
                FirstName = "Drake",
                LastName = "Cao"
            };

            Console.WriteLine(person1.Equals(person2));
            Console.ReadKey();
        }
    }
}