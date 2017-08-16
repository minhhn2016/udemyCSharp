using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s8_67
{
    public class Exe4
    {
        public static string PascalCase(string input)
        {
            // Check if the input is empty or not
            // if not empty, convert the input to Pascal Case regardless of the lower/upper state.
            // if empty, display "Error".

            var variableName = "";
            if (!String.IsNullOrWhiteSpace(input))
            {
                foreach (var word in input.Split(' '))
                {
                    var wordToPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                    variableName += wordToPascalCase;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            return variableName;
        }
    }
}
