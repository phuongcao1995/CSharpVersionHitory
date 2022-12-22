using System;

namespace PatternMatching
{
    public class Shape
    {

    }
    public class Circle : Shape
    {
        public int Radius { get; set; }

    }
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Weight { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle()
            {
                Height = 9,
                Weight = 9
            };

            if (shape is Rectangle r)
            {
                Console.WriteLine(r.Height);
            }

            switch (shape)
            {
                case Circle circle:
                    Console.WriteLine("circle");
                    break;
                case Rectangle rectangle when rectangle.Height == 8:
                    Console.WriteLine("rectangle");
                    break;
                case Rectangle rec when rec.Height == rec.Weight:
                    Console.WriteLine("rec");
                    break;

                default:
                    break;
            }
            var point = (9, 9);

            switch (point)
            {
                //case ((shape as Rectangle).Height, ((shape as Rectangle).Weight)):
                //    Console.WriteLine("circle");
                //    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
