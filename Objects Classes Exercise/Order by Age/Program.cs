using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> members = new List<Person>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0].ToUpper() == "END")
                {
                    break;
                }

                Person nextName = new Person(command[0], command[1], int.Parse(command[2]));
                members.Add(nextName);

            }

            members = members.OrderBy(x => x.Age)
                             .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, members));
        }
    }
    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
