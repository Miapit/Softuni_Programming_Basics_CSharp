using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H_USD_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double lev = usd * 1.79549;
            Console.WriteLine($"{lev:F2}");
        }
    }
}
