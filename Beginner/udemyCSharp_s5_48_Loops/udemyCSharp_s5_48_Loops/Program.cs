using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s5_48_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code to demo Exercise 1.
            // Count the number of numbers between 1 and 100 that is divisible by 3
            // without remainder

            Console.WriteLine("The count of numbers that divisible by 3 without remainder: " + udemyCSharp_s5_48_Loops.Exe1_DivisorCount.DivisorCount());

            // Code to demo Exercise 2.
            // Continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers.
            // Display the result on the console.

            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or \"ok\" to exit):");
                var input = Console.ReadLine().ToLower();
                if (input == "ok" || String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    var number = Convert.ToInt32(input);
                    sum += number;
                }
            }
            Console.WriteLine("Sum of entered numbers: " + sum);

            // Code to demo Exercise 3.
            // Ask the user to enter a number.
            // Compute the factorial of the number and print it on the console.

            Console.WriteLine("Enter a number to calculate its factorial: ");
            var input1 = Console.ReadLine();
            Console.WriteLine("Factorial of {0} is {1}", input1, udemyCSharp_s5_48_Loops.Exe3_CalculateFactorial.CalculateFactorial(input1));

            // Code to demo Exercise 4.
            // Program picks a random number between 1 and 10.
            // User has 4 chances to guess.
            // If user makes correct guess, display "You won"; otherwise, display "You lost"

            var randomizedNumber = new Random().Next(1, 10);
            var counter = 0;

            while (counter < 4)
            {
                Console.WriteLine("Make your guess between 1 and 10:");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomizedNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
                counter++;
            }
            Console.WriteLine("You lost");

            // Code to demo Exercise 5.
            // Ask the user to enter a series of numbers separated by comma.
            // Find the maximum of the numbers and display it on the console.

            Console.WriteLine("Enter a series of numbers separated by comma: ");
            var input2 = Console.ReadLine();
            Console.WriteLine("The max number is: " + udemyCSharp_s5_48_Loops.Exe5_FindMax.FindMax(input2));
        }
    }
}
