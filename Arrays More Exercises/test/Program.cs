using System;
using System.Linq;

namespace Pascal_Triangel

{
    class Program
    {
        static void Main(string[] args)
        {
            //int no_row, c = 1, blk, i, j;

            //Console.Write("\n\n");
            //Console.Write("Display the Pascal's triangle:\n");
            //Console.Write("--------------------------------");
            //Console.Write("\n\n");

            //Console.Write("Input number of rows: ");
            //no_row = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < no_row; i++)
            //{
            //    for (blk = 1; blk <= no_row - i; blk++)
            //        Console.Write("  ");
            //    for (j = 0; j <= i; j++)
            //    {
            //        if (j == 0 || i == 0)
            //            c = 1;
            //        else
            //            c = c * (i - j + 1) / j;
            //        Console.Write("{0}   ", c);
            //    }
            //    Console.Write("\n");
            //}

            int numberOfRows = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            if (numberOfRows == 1)
            {
                return;
            }

            int[] initialArray = new int[] { 1, 1 };

            Console.WriteLine(string.Join(" ", initialArray));

            if (numberOfRows == 2)
            {
                return;
            }

            else
            {
                for (int i = 0; i < initialArray.Length + 1; i++)
                {
                    int[] array = new int[initialArray.Length + 1];

                    array[0] = 1;  // първия елемент

                    array[array.Length - 1] = 1;  // последния елемент

                    for (int j = 1; j < array.Length - 1; j++)     // елементите между първия и последния
                    {

                        array[j] = initialArray[j - 1] + initialArray[j];

                    }
                    Console.WriteLine(string.Join(" ", array));

                    initialArray = array;

                    if (initialArray.Length == numberOfRows)
                    {
                        break;
                    }
                }
            }
        }
    }
}
    

