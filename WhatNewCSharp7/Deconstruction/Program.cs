using System;

namespace Deconstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            point.X = 10;
            var (x, y) = point;
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
            Console.ReadKey();
        }
    }

    public class Point
    {
        public int X, Y;
        public void Deconstruct(out int x, out int y)
        {
            (x, y) = (X, Y);
        }
    }
}
