using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H_3Currency_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            double result = 0;
            if (currency1 == "USD")
            {
                if (currency2 == "BGN")
                {
                    result = input * usd;
                }

                else if (currency2 == "EUR")
                {
                    result = input * usd / eur;
                }

                else if (currency2 == "GBP")
                {
                    result = input * usd / gbp;
                }
            }
            else if (currency1 == "EUR")
            {
                if (currency2 == "BGN")
                {
                    result = input * eur;
                }

                else if (currency2 == "USD")
                {
                    result = input * eur / usd;
                }

                else if (currency2 == "GBP")
                {
                    result = input * eur / gbp;
                }
            }
            else if (currency1 == "GBP")
            {
                if (currency2 == "BGN")
                {
                    result = input * gbp;
                }

                else if (currency2 == "EUR")
                {
                    result = input * gbp / eur;
                }

                else if (currency2 == "USD")
                {
                    result = input * gbp / usd;
                }
            }
            else if (currency1 == "BGN")
            {
                if (currency2 == "GBP")
                {
                    result = input / gbp;
                }

                else if (currency2 == "EUR")
                {
                    result = input / eur;
                }

                else if (currency2 == "USD")
                {
                    result = input / usd;
                }
            }
            Console.WriteLine($"{result:F2}");
            Console.WriteLine();
            
            

        }
    }
}
