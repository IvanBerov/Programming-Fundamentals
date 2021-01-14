using System;
using System.Numerics;
namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var nums = new BigInteger[n];
            nums[0] = 1;
            for (int i = 1; i < n; i++)
            {
                //nums[i] = sum ot predni k 4isla 
                BigInteger sum = 0;

                for (int prev = i - k; prev <= i-1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += nums[prev];
                        nums[i] = sum;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
