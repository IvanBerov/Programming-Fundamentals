﻿using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            double result = 0;
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];

                char firstLetter = curr[0];                //A
                char lastLetter = curr[curr.Length - 1];   //b

                                                           //12
                double number = double.Parse(curr.Substring(1, curr.Length - 2));

                int firstElementIndex = alpha.IndexOf(char.ToUpper(firstLetter));
                int secondElementIndex = alpha.IndexOf(char.ToUpper(lastLetter));

                if ((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    number = number / (firstElementIndex + 1);
                }
                else
                {
                    number = number * (firstElementIndex + 1);
                }

                if ((int)lastLetter >= 65 && (int)lastLetter <= 90)
                {
                    number = number - (secondElementIndex + 1);
                }
                else
                {
                    number = number + (secondElementIndex + 1);
                }

                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
