using System;

namespace Tuples
{
    public static class Product
    {
        public static Tuple<double, double> SumAndProduct(double a, double b)
        {
            return Tuple.Create(a * b, a + b);
        }
        public static (double, double) NewSumAndProduct(double a, double b)
        {
            return (a * b, a + b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var product = Product.NewSumAndProduct(2, 5);
            Console.WriteLine(product.Item1);

            var (sum, mul) = Product.NewSumAndProduct(2, 5);
            Console.WriteLine(mul);

            var info = (name: "phuong", age: "10");
            Console.WriteLine(info.name);

            var func = new Func<double, (double sum, double mul)>(a => (a + a, a * a));
            Console.WriteLine(func(3).sum);

            Console.ReadLine();
        }
    }
}
