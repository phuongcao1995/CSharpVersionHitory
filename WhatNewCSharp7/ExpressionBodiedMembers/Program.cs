using System;
using System.Collections.Generic;

namespace ExpressionBodiedMembers
{
    public class Person
    {
        public int Id { get; set; }
        public static readonly Dictionary<int, string> names = new Dictionary<int, string>();
        public Person(int id, string name) => names.Add(id, name);
        public string Name
        {
            get => names[Id];
            set => names[Id] = value;
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1, "Phuong");
            var names = Person.names;
            var name = person.Name;
            Console.WriteLine(names);
            Console.ReadKey();
        }
    }
}
