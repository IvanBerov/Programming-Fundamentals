using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int left = 0; left < nums.Length; left++)
            {
                for (int right = left + 1; right < nums.Length; right++)
                {
                    var sum = nums[left] + nums[right];

                    if (nums.Contains(sum)) // Дали даден елемент се съдържа в масива 
                    {
                        Console.WriteLine("{0} + {1} = {2} ", nums[left], nums[right],sum);
                    }
                }
            }
        }
    }
}
