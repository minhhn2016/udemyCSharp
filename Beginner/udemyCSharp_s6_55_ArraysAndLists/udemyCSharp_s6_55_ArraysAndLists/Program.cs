using System;
using System.Collections.Generic;

namespace udemyCSharp_s6_55_ArraysAndLists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Code to demo Exercise 1.
            // Program continuously asks the user to enter different names,
            // until the user presses Enter (without supplying a name).
            // Depending on the number of names provided, display a message based on facebook's pattern.
            Console.WriteLine("Exercise 1");
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name:");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }
            switch (names.Count)
            {
                case 1:
                    Console.WriteLine("{0} likes your post.", names[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1}, and {2} other like your post.", names[0], names[1], names.Count - 2);
                    break;
            }

            // Code to demo Exercise 2.
            // Program asks the user to enter their name.
            // Display the reversed name on the console.
            Console.WriteLine("Exercise 2");
            Console.WriteLine("Enter your name: ");
            var input1 = Console.ReadLine();
            Console.WriteLine("Reversed name: " + Exe2NameReversed.NameReversed(input1));

            // Code to demo Exercise 3.
            // Program asks the user to enter 5 numbers.
            // If a number has been entered previously, display an error message,
            // and ask the user to re-try.
            // Sort 5 successully entered numbers, and display on the console.
            Console.WriteLine("Exercise 3");
            var count = 0;
            var uniques = new List<int>();

            while (count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                    count++;
                }
                else
                {
                    Console.WriteLine("The number was previously entered!");
                }
            }
            uniques.Sort();
            foreach (var number in uniques)
                Console.Write(number + " ");

            // Code to demo Exercise 4.
            // Program asks the user to continuously enter a number,
            // or type "Quit" to exit.
            // Display the unique numbers that the user has entered.
            Console.WriteLine();
            Console.WriteLine("Exercise 4");
            var numbers = new List<int>();
            var uniques1 = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number:");
                var input4 = Console.ReadLine();

                if (input4.ToLower() == "quit" || String.IsNullOrWhiteSpace(input4))
                {
                    break;
                }
                else
                {
                    var number = Convert.ToInt32(input4);
                    numbers.Add(number);
                }
            }
            foreach (var number in numbers)
            {
                if (uniques1.Contains(number)) continue;
                uniques1.Add(number);
            }
            Console.WriteLine("Unique numbers are: ");
            foreach (var number in uniques1)
            {
                Console.Write(number + " ");
            }

            // Code to demo Exercise 5.
            // Program asks the user to supply a list of comma separated numbers.
            // If the list is empty or includes less than 5 numbers,
            // display "Invalid list" and ask the user to re-try;
            // otherwise, display the 3 smallest number in the list
            Console.WriteLine();
            Console.WriteLine("Exercise 5");
            string[] elements;

            while (true)
            {
                Console.WriteLine("Enter a list of at least 5 comma separated numbers:");
                var input3 = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input3))
                {
                    elements = input3.Split(',');
                    if (elements.Length >= 5)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid list");
            }
            var numbers1 = new List<int>();
            foreach (var number in elements)
            {
                numbers1.Add(Convert.ToInt32(number));
            }
            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                var min = numbers1[0];
                foreach (var number in numbers1)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                smallest.Add(min);
                numbers1.Remove(min);
            }
            Console.WriteLine("3 smallest numbers:");
            foreach (var number in smallest)
            {
                Console.Write(number + " ");
            }
            
            
        }
    }
}
