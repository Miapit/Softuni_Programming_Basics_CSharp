using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int firstDig = num % 10;
        int secondDig = num / 10 % 10;
        int thirdDig = num / 100 % 10;

        for (int i = 1; i <= firstDig; i++)
        {
            for (int z = 1; z <= secondDig; z++)
            {
                for (int k = 1; k <= thirdDig; k++)
                {
                    int result = i * z * k;
                    Console.WriteLine($"{i} * {z} * {k} = {result};");
                }
            }
        }
    }
}