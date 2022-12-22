using System;
using System.Collections.Generic;

namespace LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> xs = OddSequence(10, 80);  // line 8
            Console.WriteLine("Retrieved enumerator...");

            foreach (var x in xs)
            {
                Console.Write($"{x} ");
            }
            Console.ReadLine();
        }

        public static IEnumerable<int> OddSequence(int start, int end)
        {
            if (start < 0 || start > 99)
                throw new ArgumentOutOfRangeException(nameof(start), "start must be between 0 and 99.");
            if (end > 100)
                throw new ArgumentOutOfRangeException(nameof(end), "end must be less than or equal to 100.");
            if (start >= end)
                throw new ArgumentException("start must be less than end.");

            return GetOddSequenceEnumerator();

            IEnumerable<int> GetOddSequenceEnumerator()
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 1)
                        yield return i;
                }
            }
        }
    }
}
