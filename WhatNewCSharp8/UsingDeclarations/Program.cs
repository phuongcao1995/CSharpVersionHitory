using System;

namespace UsingDeclarations
{
    class Program
    {
        static void ReadFile(string path)
        {

            var file = new ExtendStreamReader(path);
            Console.WriteLine(file.ReadToEnd());


            //using (var file = new ExtendStreamReader(path))
            //{
            //    Console.WriteLine(file.ReadToEnd());
            //}


            //using var file = new ExtendStreamReader(path);
            //Console.WriteLine(file.ReadToEnd());
        }

        static void Main(string[] args)
        {
            var path = @"D:\project\FPT_SharingTech\WhatNewCSharp8\UsingDeclarations\TestFile.txt";
            ReadFile(path);

            Console.ReadLine();
        }
    }
}
