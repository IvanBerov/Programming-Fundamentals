using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int currInt = arr[i];

                for (int j = i+1; j < arr.Length; j++)
                {
                    int nextInt = arr[j];

                    if (nextInt >= currInt)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(currInt + " ");
                }
                isBigger = true;
            }
        }
    }
}
