using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";

            Regex regex = new Regex(pattern);
            MatchCollection names = regex.Matches(input);

            foreach (Match name in names)
            {
                Console.Write($"{name.Value} ");
            }
           // Console.WriteLine();
        }
    }
}
