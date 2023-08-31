namespace AutoPropertyInitializer
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string FullName => string.Format("{0} {1}", FirstName, LastName);
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
        public int Salary { get; } = 9999;


        internal class Program
        {
            static void Main(string[] args)
            {
                Employee employee = new Employee();
                employee.FirstName = "Petter";
                employee.LastName = "Cao";
                Console.WriteLine(employee.FullName);
                Console.WriteLine(employee.Salary);
                Console.ReadLine();
            }
        }
    }
}