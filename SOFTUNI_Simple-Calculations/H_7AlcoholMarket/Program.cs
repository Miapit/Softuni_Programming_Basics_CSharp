using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H_7AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyCost = double.Parse(Console.ReadLine());
            double beerLeters = double.Parse(Console.ReadLine());
            double wineLeters = double.Parse(Console.ReadLine());
            double rakiaLeters = double.Parse(Console.ReadLine());
            double whiskeyLeters = double.Parse(Console.ReadLine());


            
            double rakiaCost = whiskeyCost / 2;
            double wineCost = rakiaCost * 0.6;
            double beerCost = rakiaCost * 0.2;

            double money = (rakiaLeters * rakiaCost) + (beerLeters * beerCost) + (wineLeters * wineCost) + (whiskeyCost * whiskeyLeters);

            Console.WriteLine($"{money:F2}");
        }
    }
}
