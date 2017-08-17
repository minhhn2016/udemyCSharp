using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s8_67
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Code to demo Exe1.cs
            // Write a program and ask the user to enter a few numbers separated
            // by a hyphen, then determine if the numbers are consecutive.

            Console.WriteLine("Enter your numbers separated by a hyphen:");
            var input = Console.ReadLine();
            Console.WriteLine(Exe1.CheckConsecutive(input));

            // Code to demo Exe2.cs
            // Write a program and ask the user to enter a few numbers separated
            // by a hyphen, then determine if there are duplicated numbers.

            Console.WriteLine("Enter your numbers separated by a hyphen:");
            var input1 = Console.ReadLine();
            Console.WriteLine(Exe2.CheckDuplicate(input1));

            // Code to demo Exe3.cs
            // Write a program and ask the user to enter a time value in the 24-hour
            // time format (e.g. 19:00), then determine if it's valid.

            Console.WriteLine("Enter your time in 24-hour format (e.g. 19:00):");
            var input2 = Console.ReadLine();
            Console.WriteLine(Exe3.checkValidTime(input2));
            
            
            // Code to demo Exe4.cs
            // Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase.
            Console.WriteLine("Enter a few words separated by a space:");
            var input3 = Console.ReadLine();
            Console.WriteLine(Exe4.PascalCase(input3));
            

            // Code to demo Exe5.cs
            // Write a program and ask the user to enter an English word.
            // Count the number of vowels in the word.

            Console.WriteLine("Enter an English word:");
            var input4 = Console.ReadLine();
            Console.WriteLine("Number of vowels: " + Exe5.CountVowels(input4));
        }
    }
}
