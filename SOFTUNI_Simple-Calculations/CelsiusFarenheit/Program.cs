﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
