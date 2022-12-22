using System;

namespace ObjectInitialization
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                Id = 1,
                Name = "Drake"
            };

            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.ReadKey();
        }
    }
}
