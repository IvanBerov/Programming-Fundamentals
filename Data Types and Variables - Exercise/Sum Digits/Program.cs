using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNum = int.Parse(input[i].ToString());
                sum += currNum;
            }
            Console.WriteLine(sum);
        }
    }
}
