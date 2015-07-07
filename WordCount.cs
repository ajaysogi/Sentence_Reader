//
//  Author: AJAY SOGI
//  Date:   07-DEC-2013
//  App:    WordCount.cs
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltMethod_SentenceReader
{
    // Create Public Static Class WordCount
    public static class WordCount
    {
        
        
        // Create a loop which search the given string and returns the ammount of times a given variable by the user
        // Occurss within the string.
        public static int WordCounter(string text, string pattern)
        {
            // Assign Variables
            int count = 0;
            int i = 0;

            // Loop through index of the sentence string and check for any matches of the given variable designated by the user
            // If true, increase count.
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }

            return count;
        }// End WordCounter
        

        
        // Create a static method which displays how many times the word chosen word by the user occurs within the sentence.
        public static void DisplayWord()
        {
            string word;

            TOP:

            // Test for any word combinations.
                Console.WriteLine("Type the word you are looking for: \n");
                word = Console.ReadLine();

            // Conduct a Presence Check to prevent blank field 
            if (word.Length == 0)
            {
                    Console.Clear();
                    // Display Error Message
                    Console.WriteLine("ERROR: The field has been left blank. Enter some text to continue . . .\n");
                    // Break loop and go to starting point
                    goto TOP;
            }

            Console.WriteLine("\n\n\nThe word " + word + " occurs {0} times in this sentence", WordCount.WordCounter(SentenceAnalyzer.sentence.ToLower(), word.ToLower()));

        }// End DisplaWord

        // Create static method for displayong all basic calculation of the user input
        public static void DisplayBasicSentenceCalculations()
        {
            // Count LENGTH/UPPERCASES/LOWERCASES/DIGITS/PUNCTUATION/WHITESPACES
            int lenCount = SentenceAnalyzer.sentence.Length;
            int upperCount = SentenceAnalyzer.sentence.Count(i => char.IsUpper(i));
            int lowerCount = SentenceAnalyzer.sentence.Count(i => char.IsLower(i));
            int digitCount = SentenceAnalyzer.sentence.Count(i => char.IsDigit(i));
            int puncCount = SentenceAnalyzer.sentence.Count(i => char.IsPunctuation(i));
            int whiteCount = SentenceAnalyzer.sentence.Count(i => char.IsWhiteSpace(i));

            // Display OUTCOME:
            Console.WriteLine("\n\n=========================================");
            Console.WriteLine("\n\n(1) LENGTH of string: {0}", lenCount);
            Console.WriteLine("\n(2) UPPERCASE letters present: {0}", upperCount);
            Console.WriteLine("\n(3) LOWERCASE letters present: {0}", lowerCount);
            Console.WriteLine("\n(4) DIGITS present: {0}", digitCount);
            Console.WriteLine("\n(5) PUNCTUATION present: {0}", puncCount);
            Console.WriteLine("\n(6) WHITESPACES present: {0}", whiteCount);
            Console.WriteLine("\n\n=========================================");

        }// END DisplayBasicSentenceCalculations()

    }// End WordCount
}
