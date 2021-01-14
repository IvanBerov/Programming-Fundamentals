using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thitdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());

            int add = firstInteger + secondInteger;
            int div = add / thitdInteger;
            int multi = div * fourthInteger;

            Console.WriteLine(multi);

        }
    }
}
