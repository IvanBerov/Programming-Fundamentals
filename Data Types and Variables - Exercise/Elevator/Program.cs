using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int count = 0;

            while (peopleNum > 0 && peopleNum != 0)
            {
                peopleNum -= capacity;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
