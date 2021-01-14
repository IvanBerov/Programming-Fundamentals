using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            string longestWord = firstWord;
            string shortesWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortesWord = firstWord;
            }

            int total = CharMultiplier(longestWord, shortesWord);
            Console.WriteLine(total);

        }
        public static int CharMultiplier(string longerWord,string shorterWord)
        {
            int sum = 0;
            for (int i = 0; i < shorterWord.Length; i++)
            {
                int multiply = longerWord[i] * shorterWord[i];
                sum += multiply;
            }
            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }

            return sum;
        }
    }
}
