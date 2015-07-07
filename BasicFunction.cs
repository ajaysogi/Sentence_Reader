//
//  Author: AJAY SOGI
//  Date:   07-DEC-2013
//  App:    BasicFunction.cs
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltMethod_SentenceReader
{
    public class BasicFunction
    {
        // newScreen created to refresh screen.
        public void  newScreen()
        {
            // Assign string Variable & Centre Allign text. 
            string Proceed = "-----> Press ENTER to continue <-----";
            Console.WriteLine("\n\n\n{0," + ((Console.WindowWidth / 2) + Proceed.Length / 2) + "}", Proceed);
            Console.ReadKey(true);
            Console.Clear();
        }

        // Assign Variables
        string intro;

        // Generate public class Intro
        public void  Intro()
        {
            // Generate Intro Text
            //=======================================================================================

            intro = "\n<------------------------Sentence_Analyzer_Application------------------------>";

            intro += "\n\nThis application is designed to analyze a user generated sentence for multiple \npieces of information";
            intro += "\n\nThe Application will calcuate:";
            intro += "\n\n\t- The amount of OCCURENCES of characters within the sentence (A-Z)";
            intro += "\n\t- The amount of UPPERCASE characters present";
            intro += "\n\t- The amount of LOWERCASE characters present";
            intro += "\n\t- The amount of DIGITS present";
            intro += "\n\t- The amount of PUNCTUATION present";
            intro += "\n\t- The amount of time a specific COMBINATION occurs, decided by the";
            intro += "\n\t  users input";
           
            intro += "\n\n*******************************************************************************";
            intro += "\n\n\t\t     Author:      A J A Y   S O G I";
            intro += "\n\t\t     Date:         7-DECEMBER-2013";
            intro += "\n\n*******************************************************************************";

            intro += "\n\n<----------------------------------------------------------------------------->";

            Console.WriteLine(intro);
        }// End Intro()

        // create new string goodbye
        string Goodbye;

        // Create goodbye method
        public void GoodBye()
        {
            // Generate Outro Text
            //===========================================================================================

            Goodbye = "\n\n\t\t   THANK YOU FOR USING THIS APPLICATION!";
            Goodbye += "\n\n\nPlease choose one of the following options to proceed";
            Goodbye += "\n\nPress [1] to RESTART application";
            Goodbye += "\nPress [0] to QUIT application\n\n";

            Console.WriteLine(Goodbye);

        }// End GoodBye()

    
    }// End BasicFunction
}
