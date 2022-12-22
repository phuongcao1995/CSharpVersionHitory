using System;

namespace AutoProperties
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
            Student student = new Student();
            student.Id = 1;
            student.Name = "Drake";
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.ReadKey();
        }
    }
}
