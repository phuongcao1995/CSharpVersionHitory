using System;

namespace PositionalPatterns
{
    class Program
    {
        static string GetQuadrant(Point point) => point switch
        {
            (0, 0) => "Origin",
            var (x, y) when x > 0 && y > 0 => "One",
            var (x, y) when x < 0 && y > 0 => "Two",
            var (x, y) when x < 0 && y < 0 => "Three",
            var (x, y) when x > 0 && y < 0 => "Four",
            var (_, _) => "OnBorder",
            _ => "Unknown"
        };

        static void Main(string[] args)
        {
            var point = new Point();
            point.X = 10;
            point.Y = 20;
            (int a, int b) = point;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //var quadrant = GetQuadrant(point);
            //Console.WriteLine(quadrant);
            Console.ReadLine();


        }


    }
}
