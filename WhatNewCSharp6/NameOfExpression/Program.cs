namespace NameOfExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("{0} : {1}", nameof(Employee.Id), emp.Id);
            Console.WriteLine("{0} : {1}", nameof(Employee.Name), emp.Name);
            Console.WriteLine("{0} : {1}", nameof(Employee.Salary), emp.Salary);
            Console.ReadLine();
        }
    }

    class Employee
    {
        public int Id { get; set; } = 101;
        public string Name { get; set; } = "Nitin";
        public int Salary { get; set; } = 9999;
    }
}