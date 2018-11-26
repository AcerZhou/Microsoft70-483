using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Microsoft70_483
{
    public class RegexMatchPostcodeExample
    {
        public static void Example()
        {
            if (ValidateZipCodeRegEx("3000"))
            {
                Console.WriteLine("Regex check success with postcode 3000");
            }
            else
            {
                Console.WriteLine("Regex check failed with postcode 3000");
            }

            UseRegexToReplace();

        }

        private static void UseRegexToReplace()
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);
            string input = "1 2 3 4   5";
            string result = regex.Replace(input, " ");
            Console.WriteLine(result); // Displays 1 2 3 4 5
        }

        static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
