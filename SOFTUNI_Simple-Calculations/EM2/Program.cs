using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM2
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyMoney = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keychain = int.Parse(Console.ReadLine());
            int cartoon = int.Parse(Console.ReadLine());
            int luckyChance = int.Parse(Console.ReadLine());
            double total = 0;
            double hosting = 0;
            double gain = 0;
            double sumMoney = loveLetters * 0.6 + waxRoses * 7.2 + keychain * 3.6 + cartoon * 18.2 + luckyChance * 22;
            int sum = loveLetters + waxRoses + keychain + cartoon + luckyChance;

            if (sum >= 25)
            {
                double discount = sumMoney * 0.35;
                total = sumMoney - discount;
            }
            else
            {
                total = sumMoney;
            }
            hosting = total * 0.1;
            gain = total - hosting;

            if (gain > partyMoney)
            {
                double leftMoney = gain - partyMoney;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double needed = partyMoney - gain;
                Console.WriteLine($"Not enough money! {needed:F2} lv needed.");
            }
        }
    }
}
