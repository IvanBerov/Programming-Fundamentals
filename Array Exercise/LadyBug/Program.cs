using System;
using System.Linq;

namespace LadyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[size];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currIndex = initialIndexes[i];

                if (currIndex >= 0 && currIndex < field.Length) //size
                {
                    field[currIndex] = 1;
                } 
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                // 0 right 1

                int ladyBugIndex =int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);

                //Ако ви се даде индекс на калинка, който не разполага с калинка там, нищо не се случва.
                //Ако ви е даден индекс на калинка, който е извън полето, нищо не се случва.
                if (   ladyBugIndex < 0 //dolna granica
                    || ladyBugIndex > field.Length-1 //gorna granica
                    || field[ladyBugIndex] == 0) // proverqvqne na zaetost
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladyBugIndex + flyLength;

                    if (landIndex > field.Length -1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;

                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >=0 && landIndex <= field.Length -1)//da se podsigurim 4e sme vutre v poleto
                    {
                        field[landIndex] = 1;
                    } 
                }
                else if(direction == "left")
                {
                    int landIndex = ladyBugIndex - flyLength;

                    if (landIndex < 0) //dali ne izlizame ot poleto
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;

                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)//da se podsigurim 4e sme vutre v poleto
                    {
                        field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(String.Join(' ', field));

        }
    }
}
