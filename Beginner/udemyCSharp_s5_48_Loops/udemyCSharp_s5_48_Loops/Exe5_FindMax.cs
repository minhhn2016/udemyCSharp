using System;

namespace udemyCSharp_s5_48_Loops
{
    class Exe5_FindMax
    {
        public static int FindMax(string input)
        {
            var numbers = input.Split(',');
            var max = 0;
            foreach (var number in numbers)
            {
                max = (Convert.ToInt32(number) > max) ? Convert.ToInt32(number) : max;
            }
            return max;
        }
    }
}