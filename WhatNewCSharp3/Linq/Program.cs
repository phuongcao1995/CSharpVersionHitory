using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>()
            {
                "Drake Cao",
                "Phuong Cao",
                "Perter"
            };           

            var query = from l in list where l.Contains("P") select l;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
