using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litersCount = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                bool full = liters > 255; // може без тази проверка !!!
                bool overflow = litersCount + liters > 255;
                if (full || overflow)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                litersCount += liters;
            }
            Console.WriteLine(litersCount);
        }
    }
}
