using System;

namespace udemyCSharp_s5_48_Loops
{
    class Exe3_CalculateFactorial
    {
        public static long CalculateFactorial(string input)
        {
            var number = Convert.ToInt32(input);
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            return number;
        }
    }
}