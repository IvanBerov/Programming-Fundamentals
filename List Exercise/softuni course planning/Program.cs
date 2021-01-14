using System;
using System.Collections.Generic;
using System.Linq;

namespace softuni_course_planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fundamentals = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine();
            while (command != "course start")
            {
                string[] commandArgs = command.Split(":")
                    .ToArray();
                string firstCommand = commandArgs[0];
                string lessonTitel = commandArgs[1];

                if (firstCommand == "Add")
                {
                    if (!fundamentals.Contains(lessonTitel))
                    {
                        fundamentals.Add(lessonTitel);
                    }
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    if (!lessonTitel.Contains(lessonTitel))
                    {
                        fundamentals.Insert(index, lessonTitel);
                    }
                }
                else if (firstCommand == "Remove")
                {
                    fundamentals.Remove(lessonTitel);
                }
                else if (firstCommand == "Swap")
                {

                }
                else if (firstCommand == "Exercise")
                {

                }

                command = Console.ReadLine();
            }
        }
    }
}
