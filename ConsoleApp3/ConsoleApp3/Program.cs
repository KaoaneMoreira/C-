using System;
using System.IO;
using System.Collections.Generic;
using ConsoleApp3.Extensions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);

            Console.WriteLine(dt.ElapsedTime());
        }

    }
}
