using System;
using System.Collections.Generic;

namespace Ass_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Dictionary<string, int>();

            name.Add("Ivan", 38);
            name.Add("Desi", 26);
            name.Add("Georgi", 22);
            name.Remove("Georgi");

            
            string kay = "Pepo";
           
            if (!name.ContainsKey(kay))
            {
                name.Add(kay, 32);
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);

            }
        }
    }
}
