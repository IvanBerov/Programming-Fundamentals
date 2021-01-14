using System;
using System.Collections.Generic;
using System.Linq;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmgArg = command.Split();

                if (cmgArg[0] == "Add")
                {
                    wagons.Add(int.Parse(cmgArg[1]));
                }
                else
                {
                    int passangers = int.Parse(cmgArg[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currWagon = wagons[i];

                        bool isEnoughSpace = 
                            (currWagon + passangers) 
                                                    <= maxCapacity;
                        if (isEnoughSpace)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
