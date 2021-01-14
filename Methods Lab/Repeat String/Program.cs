using System;

namespace Repeat_String
{
    class Program
    {
        public static object Repeat(string input,int n) 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(input);
            }
            return input;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Repeat(input,n);
        }
    }
}
