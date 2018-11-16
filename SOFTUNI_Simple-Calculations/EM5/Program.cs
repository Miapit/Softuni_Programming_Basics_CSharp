using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM5
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthsAverageConsumtion = int.Parse(Console.ReadLine());
            double totalElectricityConsumption = 0;
            for (int i = 0; i < monthsAverageConsumtion; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                totalElectricityConsumption += electricity;
            }
            double waterConsumption = monthsAverageConsumtion * 20;
            double internetConsumption = monthsAverageConsumtion * 15;
            double others = 1.2 * (totalElectricityConsumption + internetConsumption + waterConsumption);
            double average = (totalElectricityConsumption + waterConsumption + internetConsumption + others) / monthsAverageConsumtion;
            Console.WriteLine($"Electricity: {totalElectricityConsumption:f2} lv");
            Console.WriteLine($"Water: {waterConsumption:f2} lv");
            Console.WriteLine($"Internet: {internetConsumption:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
