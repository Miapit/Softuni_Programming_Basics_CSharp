using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H_4Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double coverArea = tables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double coverKare = tables * (length/2) * (length/2);

            double priceUSD = coverArea * 7 + coverKare * 9;
            double priceBGN = priceUSD * 1.85;


            Console.WriteLine($"{priceUSD:F2} USD");
            Console.WriteLine($"{priceBGN:F2} BGN");
        }
    }
}
