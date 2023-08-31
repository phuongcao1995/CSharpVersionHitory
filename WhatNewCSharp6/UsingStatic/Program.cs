namespace UsingStatic
{
    using static System.Console;
    using static UsingStatic.MyClass;
    static class MyClass
    {
        public static void Hello()
        {
            WriteLine("Hello, World!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();
            ReadLine();
        }
    }
}