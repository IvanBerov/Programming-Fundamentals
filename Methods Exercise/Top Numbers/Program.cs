using System;

namespace Top_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNum(number);


        }

        static void PrintTopNum(int number)
        {
            for (int i = 0; i < number; i++)
            {
                string currNum = i.ToString();

                bool isOddDigit = false;

                int sumOfDigits = 0;

                foreach (var curr in currNum)
                {
                    int parseNum = (int)curr;

                    if (parseNum % 2 == 1)
                    {
                        isOddDigit = true;
                    }
                    sumOfDigits += parseNum;
                }
                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

