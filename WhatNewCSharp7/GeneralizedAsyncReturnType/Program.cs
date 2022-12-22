using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GeneralizedAsyncReturnType
{
    internal class Program
    {
        public static async Task<long> GetDirType(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
            {
                return 0;
            }
            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }

        public static async ValueTask<long> GetDirType2(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
            {
                return 0;
            }
            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }

        static void Main(string[] args)
        {
            var dir = GetDirType(@"D:\phuongcn2\source\WhatNewCSharp7").Result;
            Console.WriteLine(dir);

            var dir2 = GetDirType2(@"D:\phuongcn2\source\WhatNewCSharp7").Result;
            Console.WriteLine(dir2);

            Console.ReadLine();
        }
    }
}
