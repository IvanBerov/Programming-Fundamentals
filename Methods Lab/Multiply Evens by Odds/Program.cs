using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdd(num));
        }
        public static int SumOfEvenDigits(int num) 
        {
            int currDigits = 0;
            int sum = 0;

            while (num > 0)
            {
                currDigits = num % 10;

                if (currDigits % 2 == 0)
                {
                    sum += currDigits;
                }
                num /= 10;
            }
            return sum;
        }
        public static int SumOfOddDigits(int num)
        {
            int currDigits = 0;
            int sum = 0;

            while (num > 0)
            {
                currDigits = num % 10; // last Digit

                if (currDigits % 2 != 0)
                {
                    sum += currDigits;
                }
                num /= 10; // remove last Digit 
            }
            return sum;
        }
        public static int GetMultipleOfEvenAndOdd(int num)
        {
            return SumOfEvenDigits(num) * SumOfOddDigits(num);
        }

    }
}
