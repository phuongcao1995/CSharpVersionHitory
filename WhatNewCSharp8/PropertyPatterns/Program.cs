using System;

namespace PropertyPatterns
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        public static int GetPostalCode(Address address)
        {
            var city = address.City;
            switch (city)
            {
                case "Ha Noi": return 100000;
                case "Da Nang": return 550000;
                case "Ho Chi Minh": return 700000;
                default: return 0;
            }
        }

        //public static int GetPostalCode(Address address) =>
        //address switch
        //{
        //    { City: "Ha Noi" } => 100000,
        //    { City: "Da Nang" } => 550000,
        //    { City: "Ho Chi Minh" } => 700000,
        //    _ => 0
        //};

        static void Main(string[] args)
        {
            Address address = new Address();
            address.City = "Da Nang";
            var postalCode = GetPostalCode(address);
            Console.WriteLine(postalCode);

            Console.ReadLine();
        }
    }
}
