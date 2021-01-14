using System;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string currentLine = Console.ReadLine();

                int indexBeforeTheName = currentLine.IndexOf('@');
                int indexAfterTheName = currentLine.IndexOf('|');

                string name = currentLine.Substring(indexBeforeTheName + 1, indexAfterTheName - indexBeforeTheName - 1);

                int indexBeforeTheAge = currentLine.IndexOf('#');
                int indexAfterTheAge = currentLine.IndexOf('*');

                string age = currentLine.Substring(indexBeforeTheAge + 1, indexAfterTheAge - indexBeforeTheAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
