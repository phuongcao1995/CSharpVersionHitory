namespace ExpressionBodiedMembers
{
    internal class Program
    {
        static int Add(int a, int b) => a + b;
        static string FullName(string firstName, string lastName) => string.Format("{0} {1}", firstName, lastName);
        static string GetTime() => "Current Time - " + DateTime.Now.ToString("hh:mm:ss");
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(FullName("Petter", "Cao"));
            Console.WriteLine(GetTime());
            Console.ReadLine();
        }
    }
}