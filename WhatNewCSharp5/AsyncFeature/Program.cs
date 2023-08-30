namespace AsyncFeature
{
    internal class Program
    {

        public static IEnumerable<Product> GetProduct()
        {
            return Product.GetProductList().Result.products;
        }

        static void Main(string[] args)
        {

            var list = GetProduct();
            if (list != null)
            {
                foreach (var item in list)
                {
                    Console.Write($"Id: {item.id}   ");
                    Console.Write($"Title: {item.title}   ");
                    Console.Write($"Description: {item.description}   ");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

        }
    }
}
