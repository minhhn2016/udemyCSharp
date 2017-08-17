using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s8_67
{
    public class Exe2
    {
        public static string CheckDuplicate(string input)
        {
            // If user simply presses Enter without supplying an input, exit immediately
            // Otherwise, check to see if there are any duplicates.
            // If so, display "Duplicate" on the console.

            var message = "";
            if (!String.IsNullOrWhiteSpace(input))
            {
                var numbers = new List<int>();
                foreach (var number in input.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                var uniques = new List<int>();
                var includesDuplicates = false;

                foreach (var number in numbers)
                {
                    if (!uniques.Contains(number))
                    {
                        uniques.Add(number);
                    }
                    else
                    {
                        includesDuplicates = true;
                        break;
                    }
                }
                if (includesDuplicates)
                {
                    message = "Duplicate";
                }

            }
            return message;
        }
    }
}
