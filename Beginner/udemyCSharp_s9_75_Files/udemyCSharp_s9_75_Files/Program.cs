using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCSharp_s9_75_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code to demo Exercise 1.
            // Program to read a text file and displays the number of words.

            var path =
                @"C:\Users\Minh Hoang\Documents\Visual Studio 2017\Projects\udemyCSharp\Beginner\udemyCSharp_s9_75_Files\How to install correctly.txt";
            Console.WriteLine(File.ReadAllText(path));
            var wordsArray = File.ReadAllText(path).Split(new char[] { ' ', '\\', ':', ',', '>', '.', '\"', '?' });
            Console.WriteLine("Number of words: " + wordsArray.Length);

            // Code to demo Exercise 2.
            // Program to read a text file and displays the longest word in the file.
            var maxLength = 0;
            var longestWord = "";
            foreach (var word in wordsArray)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine("Longest word is: " + longestWord);
        }
    }
}
