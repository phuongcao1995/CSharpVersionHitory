using System;

namespace PartialMethods
{
    public partial class Program
    {
        static partial void DoSomeThing(string msg);
        static void Main(string[] args)
        {
            var msg = "Hello World";
            DoSomeThing(msg);
            Console.ReadKey();
        }
    }

    public partial class Program
    {
        static partial void DoSomeThing(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
