using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA5
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double totalElectricity = 0;
            

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                totalElectricity += electricity;
            }
            double totalWater = months * 20;
            double totalInternet = months * 15;
            double totalOther = 1.2 * (totalElectricity + totalInternet + totalWater);
            double totalaverage = (totalElectricity + totalWater +totalInternet + totalOther) / months;



            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOther:f2} lv");
            Console.WriteLine($"Average: {totalaverage:f2} lv");
        }
    }
}
