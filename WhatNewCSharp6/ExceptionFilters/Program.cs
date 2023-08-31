namespace ExceptionFilters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;
            try
            {

                var c = a / b;
            }
            catch (Exception e) when (b == 0)
            {
                Console.WriteLine("Can't be Division by zero ☺");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            int statusCode = 404;

            try
            {
                throw new Exception(statusCode.ToString());
            }
            catch (Exception e) when (e.Message == "404")
            {
                Console.WriteLine("Not Found");
            }
            catch (Exception e) when (e.Message == "401")
            {
                Console.WriteLine("Unathorized ");
            }
            catch (Exception e) when (e.Message == "403")
            {
                Console.WriteLine("Forbidden");
            }

            Console.ReadLine();
        }
    }
}