namespace NullConditionalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee petter = null;

            //petter.Address = new Address()
            //{
            //    City = "Da Nang"
            //};

            var city = petter?.Address?.City;
            if (city == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine(city);
            }
            Console.ReadKey();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Employee() { }
    }
    class Address
    {
        public int Number { get; set; }
        public int Street { get; set; }
        public int Floor { get; set; }
        public string City { get; set; }

    }
}