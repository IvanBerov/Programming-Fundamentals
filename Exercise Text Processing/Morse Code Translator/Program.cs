using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, String> morse = new Dictionary<char, String>()
            {
            {'A' , ".-"},
            {'B' , "-..."},
            {'C' , "-.-."},
            {'D' , "-.."},
            {'E' , "."},
            {'F' , "..-."},
            {'G' , "--."},
            {'H' , "...."},
            {'I' , ".."},
            {'J' , ".---"},
            {'K' , "-.-"},
            {'L' , ".-.."},
            {'M' , "--"},
            {'N' , "-."},
            {'O' , "---"},
            {'P' , ".--."},
            {'Q' , "--.-"},
            {'R' , ".-."},
            {'S' , "..."},
            {'T' , "-"},
            {'U' , "..-"},
            {'V' , "...-"},
            {'W' , ".--"},
            {'X' , "-..-"},
            {'Y' , "-.--"},
            {'Z' , "--.."},
            };


            var toReplace = string.Empty;
            string[] input = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];

                string[] deCode = word.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; i < deCode.Length; j++)
                {
                    if (deCode.Length > 1)
                    {
                    toReplace = deCode[j];
                    }
                    else
                    {
                    toReplace = deCode.ToString();
                    }    
                }
                
                StringBuilder sb = new StringBuilder();

                foreach (var item in morse)
                {
                    var old = item.Value;
                    var newChar = item.Key;

                    if (toReplace.Contains(item.Value)) // not ready
                    {
                        
                        sb.Append(item.Key);
                    }
                    
                    //   .. | -- .- -.. . |  -.-- --- ..- | .-- .-. .. - . 
                    
                }

                Console.WriteLine(sb);


            }         

        }    
    }
}
