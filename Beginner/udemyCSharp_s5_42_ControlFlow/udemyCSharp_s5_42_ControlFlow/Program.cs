using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s5_42_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code to demo Exercise 1
            // Ask the user to enter a number between 1 and 10.
            // Display "Valid" on the console for valid input; otherwise, display "Invalid"

            Console.WriteLine("Enter a number between 1 and 10:");
            var input = Console.ReadLine();
            Console.WriteLine(Exe1_InputValidation.InputValidation(input) ? "Valid" : "Invalid");

            // Code to demo Exercise 2
            // Ask the user to enter two numbers.
            // Display the maximum if the two.

            Console.WriteLine("Enter a number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The maximum number is: " + Exe2_MaximumValue.MaximumValue(firstNumber, secondNumber));

            // Code to demo Exercise 3
            // Ask the user for the width and height of an image.
            // Determine if the image is landscape or portrait and display in console.

            Console.WriteLine("Enter the width of the image: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The image is a " + (Exe3_ImageOrientation.ImageOrientation(width, height) ? "portrait" : "landscape"));

            // Code to demo Exercise 4:
            // Ask the user to enter speed limit and current car speed.
            // If current speed below speed limit, display "OK" in console.
            // If current speed is over the limit, calculate demerit points for every 5km/h above the limit.
            // Display "License suspended" if the demerit points is above 12.

            Console.WriteLine("Enter speed limit:");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter current speed:");
            var currentSpeed = Convert.ToInt32(Console.ReadLine());
            if (Exe4_DemeritPointCalculator.DemeritPointCalculator(speedLimit, currentSpeed) == 0)
            {
                Console.WriteLine("OK");
            }
            else if (Exe4_DemeritPointCalculator.DemeritPointCalculator(speedLimit, currentSpeed) > 0 && Exe4_DemeritPointCalculator.DemeritPointCalculator(speedLimit, currentSpeed) <= 12)
            {
                Console.WriteLine("Demerit Point(s): " + Exe4_DemeritPointCalculator.DemeritPointCalculator(speedLimit, currentSpeed));
            }
            else
            {
                Console.WriteLine("License suspended.");
            }
        }

    }
}
