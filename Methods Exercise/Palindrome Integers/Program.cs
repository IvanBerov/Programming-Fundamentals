﻿using System;
using System.Linq;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalendrom(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }
        static bool IsPalendrom(string text)
        {
            var reversed = text.Reverse().ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (!(reversed[i] == text[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
