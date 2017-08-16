using System;

namespace udemyCSharp_s5_42_ControlFlow
{
    class Exe1_InputValidation
    {
        public static bool InputValidation(string input)
        {
            var isValid = (Convert.ToInt32(input) >= 1 && Convert.ToInt32(input) <= 10) ? true : false;
            return isValid;
        }
    }
}