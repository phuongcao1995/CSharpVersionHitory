using System;

namespace ReadonlyMembers
{
    public struct Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area => (Height * Width);

        //public void setHeight(int height)
        //{
        //    Height = height;
        //}

        public override string ToString()
        {
            return $"Total area: {Area}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 20;
            Console.WriteLine(rectangle.ToString());
            Console.ReadLine();
        }
    }
}
