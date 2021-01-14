using System;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var numbers = new StringBuilder();
            var letters = new StringBuilder();
            var symbol = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                var chartext = str[i];

                if (char.IsDigit(chartext))
                {
                    numbers.Append(chartext);
                }
                else if (char.IsLetter(chartext))
                {
                    letters.Append(chartext);
                }
                else
                {
                    symbol.Append(chartext);
                }
            }
            Console.WriteLine($"{numbers}\n{letters}\n{symbol}");
        }
    }
}
