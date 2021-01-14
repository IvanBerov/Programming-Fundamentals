using System;
using System.Text;
using System.Linq;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                string name = string.Empty;
                string age = string.Empty;


                foreach (var item in input)
                {
                    if (item.Contains("@") && item.Contains("|"))
                    {
                        name = item;
                    }
                    if (item.Contains("#") && item.Contains("*"))
                    {
                        age = item;
                    }
                    
                }
                string newName = name.Trim('@','|');
                int newAge = int.Parse(age.Trim('#','*'));

                Console.WriteLine($"{newName} is {newAge} years old.");
            }
        }
    }
}
