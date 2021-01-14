using System;

namespace Encrypt___Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine()); 

            string[] sequenceOfStrings = new string[arrLength]; 

            int[] valueOfString = new int[arrLength];

            for (int i = 0; i < sequenceOfStrings.Length; i++)
            {
                sequenceOfStrings[i] = Console.ReadLine();       // позиция за имена в стринг масива

                int sumVowels = 0;    
                int sumConsonant = 0;

                foreach (char index in sequenceOfStrings[i])
                {
                    if (index == 'a' || index == 'e' || index == 'i' || index == 'o' || index == 'u'
                        || index == 'A' || index == 'E' || index == 'I' || index == 'O' || index == 'U')
                    {
                        sumVowels += ((int)index * sequenceOfStrings[i].Length);     // (int)index стоиноста на буквата в дадения индекс 
                    }
                    else
                    {
                        sumConsonant += ((int)index / sequenceOfStrings[i].Length);
                    }
                }

                int stringSum = sumVowels + sumConsonant;

                valueOfString[i] = stringSum;                   //числени стойности в инт масива

            }

            Array.Sort(valueOfString);    // подржда стойностите по големина 

            foreach (int value in valueOfString)
            {
                Console.WriteLine(value);
            }
        }
    }
}
