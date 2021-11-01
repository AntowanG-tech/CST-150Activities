using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150Activity12
{
    class Program
    {
        static void Main(string[] args)
        {
            //had some trouble getting the file pathh to work with just the file name. Instead, I had to provide the full path for the program to
            //work. The program was trying to look for file in the applications debug folder.

            string fileText = @"C:\Users\hoodi\source\repos\CST-150Activities\CST-150Activity12\CST150Activity12Text.txt";
            Console.WriteLine("The words in the document that end with 't' or 'e' amount to " + doesTheWordHaveTorEAtTheEnd(splittingTheDoc(ReadingTheFile(fileText))));

        }

        private static string ReadingTheFile(string fileText)
        {
            //Getting the file text. Reading the file as one string
            string text = System.IO.File.ReadAllText(fileText);


            //Display the file contents to the console. Variable text is a string.
            Console.WriteLine(text + "\n");

            //returns the array of words in the document
            return text;
        }

        private static int doesTheWordHaveTorEAtTheEnd(string[] wordsFromFile)
        {
            int validContForTAndE = 0;                  //holds the value for the quantity of words that qualify

            for (int i = 0; i < wordsFromFile.Length; i++)
            {
                string wordInFile = wordsFromFile[i];

                //checks if words in the text file end with e, t, E, or T. Count goes up by 1 if the word fits criteria
                if (wordInFile.EndsWith("e") || wordInFile.EndsWith("t") || wordInFile.EndsWith("T") || wordInFile.EndsWith("E"))
                {
                    validContForTAndE++;
                }
            }

            return validContForTAndE;
        }

        private static String[] splittingTheDoc(string fileWords)
        {
            //splits the string that was pulled from the .txt file into an array of strings, excluding the shown grammatical operators
            char[] separatingOps = { ' ', '.', ',', '(', ')', '-', '!', '\r', '\n' };

            string[] docWordArray = fileWords.Split(separatingOps, StringSplitOptions.RemoveEmptyEntries);

            return docWordArray;

        }
    }
}
