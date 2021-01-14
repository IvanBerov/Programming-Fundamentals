using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359(-| )2(\1)(\d{3})(\1)(\d{4})\b";
            Regex regex = new Regex(pattern);
            
            var phones = Console.ReadLine();
            var phoneMaches = regex.Matches(phones);

            string[] matchedPhons = phoneMaches.Cast<Match>()
                                          .Select(a => a.Value.Trim())
                                          .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhons));

        }
    }
}
