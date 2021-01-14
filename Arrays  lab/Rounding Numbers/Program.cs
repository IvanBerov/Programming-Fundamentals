using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] roundedNums = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
            }
            Console.WriteLine($"{num} => {roundedNums}");
        }
    }
}
