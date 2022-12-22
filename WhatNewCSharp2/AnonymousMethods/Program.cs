using System;

namespace AnonymousMethods
{
    public delegate void Print(int value);
    public class Program
    {
        public static void PrintHelperMethod(Print print, int value)
        {
            var val = value * value;
            print(val);
        }

        static void Main(string[] args)
        {
            Print print = delegate (int val)
            {
                Console.WriteLine(val);
            };

            PrintHelperMethod(print, 10);
            Console.ReadLine();
        }
    }
}
