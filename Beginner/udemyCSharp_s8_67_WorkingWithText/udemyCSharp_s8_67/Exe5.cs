using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s8_67
{
    public class Exe5
    {
        // Make sure the program calculates the number of vowels irrespective of the casing of the word.
        public static int CountVowels(string input)
        {
            var counter = 0;
            var vowels = new List<char>(new char[] {'a','e','o','u','i'});
            var charArray = input.ToLower().ToCharArray();
            foreach (var character in charArray)
            {
                if (vowels.Contains(character))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
