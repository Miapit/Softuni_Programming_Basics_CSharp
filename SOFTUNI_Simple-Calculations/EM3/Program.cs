using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM3
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string type = Console.ReadLine();
            string desert = Console.ReadLine();
            int monthsBy = int.Parse(Console.ReadLine());
            double package = 0;
            double totalSum = 0;
            switch (years)
            {
                case "one":
                    switch (type)
                    {
                        case "Small":
                            package = 9.98;
                            break;
                        case "Middle":
                            package = 18.99;
                            break;
                        case "Large":
                            package = 25.98;
                            break;
                        case "ExtraLarge":
                            package = 35.99;
                            break;
                        default:
                            break;
                    }
                    break;
                case "two":
                    switch (type)
                    {
                        case "Small":
                            package = 8.58;
                            break;
                        case "Middle":
                            package = 17.09;
                            break;
                        case "Large":
                            package = 23.59;
                            break;
                        case "ExtraLarge":
                            package = 31.79;
                            break;
                    }
                    break;
            }
            if (desert == "yes")
            {
                if (package <= 10)
                {
                    package += 5.5;
                }
                else if (package <= 30)
                {
                    package += 4.35;
                }
                else
                {
                    package += 3.85;
                }
            }
            if (years == "two")
            {
                package *= 96.25 / 100;
            }
            totalSum = monthsBy * package;
            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}
