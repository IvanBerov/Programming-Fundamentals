using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = Factorial(num1) / Factorial(num2);
            Console.WriteLine($"{result:f2}");
        }
        static decimal Factorial(int num)
        {
            decimal factoria = 1;
            for (int i = 1; i <= num; i++)
            {
                factoria *= i;
            }
            return factoria;
        }
    }
}
