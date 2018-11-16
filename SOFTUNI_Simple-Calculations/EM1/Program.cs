using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM1
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double quantityWater = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityChampaqin = double.Parse(Console.ReadLine());
            double quantityWhisky = double.Parse(Console.ReadLine());

            double priceChampaqin = whiskyPrice * 0.5;
            double priceWine = priceChampaqin * 0.4;
            double priceWater = priceChampaqin * 0.1;

            double sum = quantityWhisky * whiskyPrice + quantityWater * priceWater + quantityWine * priceWine + quantityChampaqin * priceChampaqin;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
