using System;
using System.Linq;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            VowelsCount(text);
        }
        static void VowelsCount(string text)
        {
            int counter = 0;

            //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (vowels.Contains(text[i]))  дали има елемент от масива vowels
            //    {
            //        counter++;
            //    }
            //}
            

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        counter++;
                        break;
                    case 'e':
                        counter++;
                        break;
                    case 'i':
                        counter++;
                        break;
                    case 'o':
                        counter++;
                        break;
                    case 'u':
                        counter++;
                        break;
                }
            }
            Console.WriteLine(counter);
        }

    }
}
