using System;

namespace StaticLocalFunctions
{
    class Program
    {
        static int M()
        {
            int y;
            LocalFunction();
            return y;

            void LocalFunction() => y = 0;
        }

        static void CheckNumber(int x)
        {
            DoSomeThing();
            if (x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            void DoSomeThing()
            {
                x++;
                //do something
            }
        }

        static void Main(string[] args)
        {
            int number = 2;
            CheckNumber(number);
            Console.ReadLine();
        }
    }
}
