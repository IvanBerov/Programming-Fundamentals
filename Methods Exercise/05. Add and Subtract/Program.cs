using System;
using System.Numerics;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Subtract(a,b,c);
            Console.WriteLine(result);
        }
        static int Sum(int num1,int num2)
        {
            return (num1 + num2);
        }
        static int Subtract(int num1,int num2,int num3)
        {
            return Sum(num1,num2)-(num3);
        }
    }
}
