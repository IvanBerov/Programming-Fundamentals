﻿using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            // за работа с пари ползваме decimal 

            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollars = pound * 1.31M;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
