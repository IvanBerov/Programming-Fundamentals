﻿using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < field.Length; i++)
            {
                var currChar = field[i];

                if (currChar == '>')
                {
                    bomb += int.Parse(field[i + 1].ToString());
                    continue;
                }
                if (bomb > 0)
                {
                    field = field.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }

            Console.WriteLine(field);

        }
    }
}
