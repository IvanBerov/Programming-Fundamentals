using System;
using System.Text;
using System.Linq;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string random = Console.ReadLine();

            int start = (int)Math.Min(first, second);
            int end = (int)Math.Max(first, second);

            int sum = 0;

            for (int i = 0; i < random.Length; i++)
            {
                int currChar = (int)(random[i]);

                if (currChar>start && currChar<end)
                {
                    sum += currChar;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
