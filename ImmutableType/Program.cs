using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 v = 5;
            Console.WriteLine("{0}, {1}, {2}", v, v, v);

            Object o = v;
            Console.WriteLine("{0}, {1}, {2}", o, o, o);

            Console.WriteLine("Hello World!");
        }
    }
}