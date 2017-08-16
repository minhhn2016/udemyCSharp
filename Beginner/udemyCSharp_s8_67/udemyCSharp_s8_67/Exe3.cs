using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s8_67
{
    public class Exe3
    {
        public static string checkValidTime(string input)
        {
            // If the time is valid, display "OK";
            // Otherwise display "Invalid time".
            // If the user doesn't provide any values, consider it as invalid time.
            var message = "";
            if (!String.IsNullOrWhiteSpace(input))
            {
                var elements = input.Split(':');
                if (elements.Length > 2)
                {
                    message = "Invalid time";
                }
                else
                {
                    try
                    {
                        var hour = Convert.ToInt32(elements[0]);
                        var minute = Convert.ToInt32(elements[1]);

                        if (hour >= 0 && hour <= 24 && minute >= 0 && minute <= 59)
                        {
                            message = "OK";
                        }
                        else
                        {
                            message = "Invalid time";
                        }
                    }
                    catch (Exception)
                    {
                        message = "Invalid time";
                    }
                }
            }
            return message;
        }
    }
}
