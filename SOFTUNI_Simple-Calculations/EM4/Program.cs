using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM4
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double spentMoney = 0;
            double total = 0;
            int balloons = 0;
            int ribbons = 0;
            int flowers = 0;
            int candles = 0;
            double initialBudget = money;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    Console.WriteLine($"Spend money: {total:f2}");
                    Console.WriteLine($"Money left: {initialBudget - total:f2}");
                    break;
                }
                int number = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case "balloons":
                        spentMoney = number * 0.1;
                        balloons += number;
                        break;

                    case "flowers":
                        spentMoney = number * 1.5;
                        flowers += number;
                        break;
                    case "candles":
                        spentMoney = number * 0.5;
                        candles += number;
                        break;
                    case "ribbon":
                        spentMoney = number * 2;
                        ribbons += number;
                        break;
                    default:
                        break;
                }
                total += spentMoney;
                money = money - spentMoney;
                if (money <= 0)
                {
                    Console.WriteLine($"All money is spent!");
                    break;
                }
            }
            Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbons} m ribbon, {flowers} flowers and {candles} candles.");
        }
    }
}
