//
//  Author: AJAY SOGI
//  Date:   07-DEC-2013
//  App:    SentenceAnalyzer.cs
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AltMethod_SentenceReader
{
    class SentenceAnalyzer
    {
        // Create private const int variables to process input of re-running or exiting the application
        private const int YES = 1;
        private const int NO = 0;

        // Create Public static string for accsess by any class
        public static string sentence;

        public void Run()
        {
            // Set Console Window Height to fit all text within screen
            Console.WindowHeight = 30;

            // Assign exit variable as an int
            int ExitApp = 0;

            do
            {

                // INTRO 
                //=====================================================================================================
                // Call Intro method from basic functions class and display intro message
                // Call newScreen method to refresh screen 
                BasicFunction BF = new BasicFunction();
                BF.Intro();
                BF.newScreen();

                // MAIN FUNCTION
                //======================================================================================================

                // Assign a temp local variable
                string sentenceNoWhiteSpace;

            TOP: // starting point for when the loop is broken 

                // Take user input and assign user input to senetce.
                Console.WriteLine("\nPlease enter some text . . .\n");
                sentence = Console.ReadLine();

                // Conduct a Presence Check to prevent blank field 
                if (sentence.Length == 0)
                {
                    Console.Clear();
                    // Display Error Message
                    // Messagebox.("ERROR: The field has been left blank. Enter some text to continue . . .\n");
                    MessageBox.Show("ERROR: The field has been left blank. Enter some text to continue . . .");
                    // Break loop and go to starting point
                    goto TOP;
                }

                Console.Clear();
                Console.WriteLine(sentence);

                // Create a new string & Remove whitespaces using Regular Expressions
                sentenceNoWhiteSpace = Regex.Replace(sentence, @" ", "");

                // Convert all leters to lowercase/Convert to a char array
                char[] charArray = sentenceNoWhiteSpace.ToLower().ToCharArray();

                // Sort array into alphabetical order
                Array.Sort(charArray);

                // Create Dictionary which stores each character and the ammount of times it occurs within the sentence.
                Dictionary<char, int> counter = new Dictionary<char, int>();

                // Create a temporary variable.
                int temp = 0;

                
                // Loop through each character in the array
                foreach (var letter in charArray)
                {
                    //Get value associated with specified key
                    if (counter.TryGetValue(letter, out temp))
                    {
                        counter[letter] += 1;
                    }
                    else
                    {
                        counter.Add(letter, 1);
                    }
                } // End Foreach Loop

                // Retrive data from dictionary and display how many times each character has occured.
                Console.WriteLine("\n================================");
                foreach (KeyValuePair<char, int> letter in counter)
                {   
                    Console.WriteLine(string.Format("\nTotal Number of: {0} = {1}", letter.Key.ToString(), letter.Value));
                } //End Foreach Loop
                Console.WriteLine("\n================================");

                // Refresh Screen
                BF.newScreen();

                // Display Sentence string  
                Console.WriteLine(sentence);

                // Display all basic calculations of sentence.
                WordCount.DisplayBasicSentenceCalculations();

                //Refresh Screen
                BF.newScreen();

                // ADDITIONAL FUNCTONALITY
                //=================================================================================================================
                // Test for any word combinations and display them out to user.
                WordCount.DisplayWord();

                // OUTRO
                //==================================================================================================================
                //Refresh Screen
                BF.newScreen();

                // Prompt User to RESART application or EXIT application
                BF.GoodBye();

            
                // Pass User input as a int
                ExitApp = int.Parse(Console.ReadLine());
              
            Console.Clear();

            }// End Do Loop

            // Terminate Application
            while (ExitApp != NO);
        }

        // Start Main Menthod
        static void Main(string[] args)
        {
            // Create Vairable for class SentenceAnalyzer
            SentenceAnalyzer R = new SentenceAnalyzer();
            // Call run method from class
            R.Run();
        }// End Main
    }// End Class
}// End Namespace
