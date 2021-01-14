using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            ValidatePass(pass);
        }
        static void ValidatePass(string text)
        {
            bool invalid = false;
            if (text.Length <6 || text.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (CheckTheSymbol(text) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (CountNumDigits(text) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckTheSymbol (string text)
        {
            for (int i = 0; i < text.Length; i++)   //какви символи има
            {
                char currChar = text[i];

                if (!((currChar>=48 && currChar<=57)
                    ||(currChar>=65 && currChar<=90)
                    ||(currChar>=97 && currChar<=122)))
                {
                    return false;
                }
            }
            return true;
        }
        static int CountNumDigits(string text)
        {
            int digitsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }
    }
}
