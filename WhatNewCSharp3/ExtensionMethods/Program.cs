using System;

namespace ExtensionMethods
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var name = "Drake";
            Console.WriteLine(name.CountCharacter());
            Console.ReadKey();
        }

        static int CountCharacter(this string input)
        {
            return input.Length;
        }
    }
}
