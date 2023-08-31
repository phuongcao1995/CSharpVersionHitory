namespace DeclarationExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse("10", out var result))
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("Invalid");

            Console.ReadLine();
        }
    }
}