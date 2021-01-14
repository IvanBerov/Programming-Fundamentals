using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commAgr = command.Split();

                string firstCommand = commAgr[0];
                int element = int.Parse(commAgr[1]);

                if (firstCommand == "Delete")
                {
                    integers.RemoveAll(x => x == element);
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(commAgr[2]);
                    integers.Insert(index, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
