using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int firstNum = arr[i];

                for (int j = i+1; j < arr.Length; j++)
                {
                    int secondNum = arr[j];

                    if (firstNum + secondNum == number)
                    {
                        Console.WriteLine($"{firstNum} {secondNum}");
                        break;
                    }
                }
            }
        }
    }
}
