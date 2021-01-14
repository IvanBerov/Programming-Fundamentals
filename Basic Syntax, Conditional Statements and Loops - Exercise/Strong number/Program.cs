using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;

            int currNum = 0;
            int factorielSum = 0;

            while (number!=0)
            {
                currNum = number % 10; //взимаме последна цифра
                number /= 10; // премзхваме последна цифра
                int factoriel = 1;

                for (int i = 1; i <= currNum; i++)
                {
                    factoriel *= i;                   // сума на факториел !!!
                }
                factorielSum += factoriel;
            }

            string result = string.Empty;

            if (input == factorielSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }
            Console.WriteLine(result);
        }
    }
}
