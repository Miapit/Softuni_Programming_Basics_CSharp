using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double spent = 0;
            double spentMoneyTotal = 0;
            int purchasedBalloons = 0;
            int purchasedRibbons = 0;
            int purchasedFlowers = 0;
            int purchasedCandles = 0;
            double initialBudget = budget;
            while (true)
            {
                
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    Console.WriteLine($"Spend money: {spentMoneyTotal:f2}");
                    Console.WriteLine($"Money left: {initialBudget- spentMoneyTotal:f2}");
                    break;
                }
                int number = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case "balloons":
                        spent = number * 0.1;
                        purchasedBalloons += number; 
                        break;
                        
                    case "flowers":
                        spent = number * 1.5;
                        purchasedFlowers += number;
                        break;
                    case "candles":
                        spent = number * 0.5;
                        purchasedCandles += number;
                        break;
                    case "ribbon":
                        spent = number * 2;
                        purchasedRibbons += number; 
                        break;
                    default:
                        break;
                }
                spentMoneyTotal += spent;
                budget = budget - spent;
                if (budget <= 0)
                {
                    Console.WriteLine($"All money is spent!");
                    break;
                }

            }
            Console.WriteLine($"Purchased decoration is {purchasedBalloons} balloons, {purchasedRibbons} m ribbon, {purchasedFlowers} flowers and {purchasedCandles} candles.");
        }
    }
}
