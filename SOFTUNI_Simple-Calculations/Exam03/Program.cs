using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ta
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Видове /

            //            (sashimi)(maki)(uramaki)(temaki)

            //Sushi Zone 4.99 лв. 5.29 лв. 5.99 лв. 4.29 лв.
            //Sushi Time 5.49 лв. 4.69 лв. 4.49 лв. 5.19 лв.
            //Sushi Bar 5.25 лв. 5.55 лв. 6.25 лв. 4.75 лв.
            //Asian Pub 4.50 лв. 4.80 лв. 5.50 лв. 5.50 л

            string sushi = Console.ReadLine();
            string nameRestaurant = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double total = 0;

            double money = 0;
            switch (nameRestaurant)
            {
                case "Sushi Zone":
                    switch (sushi)
                    {
                        case "sashimi":
                            money = count * 4.99;
                            break;
                        case "maki":
                            money = count * 5.29;
                            break;
                        case "uramaki":
                            money = count * 5.99;
                            break;
                        case "temaki":
                            money = count * 4.29;
                            break;
                    }
                    break;

                case "Sushi Time":
                    switch (sushi)
                    {
                        case "sashimi":
                            money = count * 5.49;
                            break;
                        case "maki":
                            money = count * 4.69;
                            break;
                        case "uramaki":
                            money = count * 4.49;
                            break;
                        case "temaki":
                            money = count * 5.19;
                            break;
                    }
                    break;
                case "Sushi Bar":
                    switch (sushi)
                    {
                        case "sashimi":
                            money = count * 5.25;
                            break;
                        case "maki":
                            money = count * 5.55;
                            break;
                        case "uramaki":
                            money = count * 6.25;
                            break;
                        case "temaki":
                            money = count * 4.75;
                            break;
                    }
                    break;
                case "Asian Pub":
                    switch (sushi)
                    {
                        case "sashimi":
                            money = count * 4.50;
                            break;
                        case "maki":
                            money = count * 4.8;
                            break;
                        case "uramaki":
                            money = count * 5.50;
                            break;
                        case "temaki":
                            money = count * 5.5;
                            break;
                    }
                    break;

            }

            if (nameRestaurant != "Sushi Zone" && nameRestaurant != "Sushi Time" && nameRestaurant != "Sushi Bar" && nameRestaurant != "Asian Pub")
            {

                Console.WriteLine($"{nameRestaurant} is invalid restaurant!");
            }
            else if (symbol == 'Y')
            {
                double delivery = 0.2 * money;
                total = delivery + money;
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
            else if (symbol == 'N')
            {
                total = money;
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
        }
    }
}