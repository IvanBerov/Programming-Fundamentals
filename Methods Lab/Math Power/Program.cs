﻿using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(a, b));

        }

        public static double MathPower(double a , double b)
        {
            return Math.Pow(a, b);
        }
    }
}
