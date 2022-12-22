using System;

namespace OutVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.TryParse("1/1/2022", out var date))
            {
                Console.WriteLine(date.Year);
            }
            Console.ReadLine();
        }
    }
}
