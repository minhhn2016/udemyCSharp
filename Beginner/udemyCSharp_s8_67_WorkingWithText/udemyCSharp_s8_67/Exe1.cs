using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s8_67
{
    public class Exe1
    {
        public static string CheckConsecutive(string input)
        {
            // Work out if the numbers are consecutive
            var message = "";
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();
            
            for (int i = 1; i < numbers.Count ; i++)
            {
                message = numbers[i] == numbers[i-1] + 1 ? "Consecutive" : "Not consecutive";
            }
            return message;
        }

    }
}
