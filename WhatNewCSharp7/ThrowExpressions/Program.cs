using System;

namespace ThrowExpressions
{
    public class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name ?? throw new ArgumentNullException(name);
        public string GetFirstName()
        {
            var parts = Name.Split(" ");
            if(parts.Length > 0 || string.IsNullOrWhiteSpace(parts[0]))
            {
                throw new InvalidOperationException("No name!");
            }
            return parts[0];
        }
        public string GetLastName() => throw new NotImplementedException();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new Person(String.Empty);
                person.GetFirstName();
                person.GetLastName();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.ReadKey();

        }
    }
}
