using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();

            if (character.Length % 2 == 0)
            {
                Console.WriteLine(MiddleCharEven(character));
            }
            else
            {
                Console.WriteLine(MiddleCharOdd(character));
            }
        }
        static string MiddleCharEven(string text)
        {
            int index = text.Length / 2; // разделя текста на две
            string chars = text.Substring(index - 1, 2); //взема средните два
            return chars;
        }
        static string MiddleCharOdd(string input)
        {
            int index = input.Length / 2; // разделя текста на две
            string chars = input.Substring(index, 1); //взема средните два
            return chars;
        }
    }
}
