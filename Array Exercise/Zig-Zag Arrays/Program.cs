using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currArray = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string indexZeroElement = currArray[0];
                string indexFirstElement = currArray[1];

                //even
                if (i % 2 == 0)
                {
                    firstArray[i] = indexZeroElement;
                    secondArray[i] = indexFirstElement;
                }
                //odd
                else if (i % 2 == 1)
                {
                    firstArray[i] = indexFirstElement;
                    secondArray[i] = indexZeroElement;
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
