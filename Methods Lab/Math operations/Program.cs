using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            double result = Calculation(firstNum, @operator, secondNum);
            Console.WriteLine(result);
            
        }

        private static double Calculation(double first,string @operator, double second)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = first + second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
                case "-":
                    result = first - second;
                    break;

            }
            return result;
        }
    }
}
