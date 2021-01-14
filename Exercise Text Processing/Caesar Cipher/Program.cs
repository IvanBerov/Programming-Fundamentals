using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach(char ch in input)
            {
                var currChar = (char)(ch + 3);
                Console.Write(currChar);
            }
        }
    }
}
