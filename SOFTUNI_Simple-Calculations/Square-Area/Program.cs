using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sqr = Math.Pow(a , 2);
            Console.WriteLine(sqr);
        }
    }
}
