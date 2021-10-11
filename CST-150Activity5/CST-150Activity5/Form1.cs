using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CST_150Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                StreamReader inputFile;
                string wordFromFile;
                
                

                //Checks and displays whether the user chose the open or cancel buttons
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    MessageBox.Show("You clicked the Open button.");

                    //Open the selected file and get a StreamReader object.
                    inputFile = File.OpenText(openFile.FileName);

                    //Clear anything currently in the listOfWords_txtbox
                    listOfWords_txtbox.Clear();

                    //Continue processing the file...


                    //Read the file's contents.
                    while (!inputFile.EndOfStream)
                    {
                        //Get a word from the List in the text file
                        wordFromFile = inputFile.ReadToEnd();

                        //add the word from the text file to the listOfWords_txtbox

                        listOfWords_txtbox.Text = wordFromFile;

                    }

                    //close the file
                    inputFile.Close();

                }
                else
                {
                    MessageBox.Show("You clicked the Cancel button.");
                }
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lowercase_btn_Click_Click(object sender, EventArgs e)
        {
            try
            {
                //converts all text within the file to lower case strings
                string toLowerCaseOutput = listOfWords_txtbox.Text.ToLower();
                result_textBox.AppendText(Environment.NewLine);
                result_textBox.AppendText("Lowercase Output: ");
                result_textBox.AppendText(Environment.NewLine);
                result_textBox.AppendText(toLowerCaseOutput);
                result_textBox.AppendText(Environment.NewLine);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                    }

        private void findFirstAndLast_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // divides words in the document into indidvidual words
                string wordsFromTheTextDoc = listOfWords_txtbox.Text;
                string[] docWordArray = wordsFromTheTextDoc.Split(' ', '.', ',', '(', ')', '-', '!', '\r', '\n');

                //gets the first word in alphabetical order
                Array.Sort(docWordArray);

                //remove empty values from the array
                docWordArray = docWordArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                //identify the first and last word of the sorted array
                string firstWord = docWordArray[0];
                string lastWord = docWordArray[docWordArray.Length - 1];

                result_textBox.AppendText(Environment.NewLine);
                result_textBox.AppendText("First Word: " + firstWord);
                result_textBox.AppendText(Environment.NewLine);
                result_textBox.AppendText("Last Word: " + lastWord);
                result_textBox.AppendText(Environment.NewLine);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void findLongestWord_btn_Click(object sender, EventArgs e)
        {
            // scan each word in the array to see if it's the longest word.

            int letterCount = 0;
            string longestWord = "";

            //the text that is already displayed in the text box.
            string wordsFromFile = listOfWords_txtbox.Text;

            string[] docWordArray = wordsFromFile.Split(' ', '.', ',', '(', ')', '-', '!', '\r', '\n');

            //gets the first word in alphabetical order
            Array.Sort(docWordArray);

            //remove empty values from the array
            docWordArray = docWordArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            //scanning for longest word
            foreach (string word in docWordArray)
            {
                if (word.Length > letterCount)
                {
                    longestWord = word;
                    letterCount = word.Length;
                }
            }

            result_textBox.AppendText(Environment.NewLine);
            result_textBox.AppendText("Longest Word: " + longestWord);
            result_textBox.AppendText(Environment.NewLine);


        }

        private void mostVowels_btn_Click(object sender, EventArgs e)
        {
            //Button for finding the word with the most vowels

            //variables
            int vowelCount = -1;
            string wordWithMostVowels = "";

            //the text that is already displayed in the text box.
            string wordsFromFile = listOfWords_txtbox.Text;

            string[] docWordArray = wordsFromFile.Split(' ', '.', ',', '(', ')', '-', '!', '\r', '\n');

            //gets the first word in alphabetical order
            Array.Sort(docWordArray);

            //remove empty values from the array
            docWordArray = docWordArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            //scanning for word with most vowels
            foreach (string word in docWordArray)
            {
                int numberOfVowelsSoFar = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') numberOfVowelsSoFar++;
                }
                if (numberOfVowelsSoFar > vowelCount )
                {
                    vowelCount = numberOfVowelsSoFar;
                    wordWithMostVowels = word;
                }
            }

            result_textBox.AppendText(Environment.NewLine);
            result_textBox.AppendText("Most Vowels: " + wordWithMostVowels);
            result_textBox.AppendText(Environment.NewLine);

        }

        private void saveToFile_btn_Click(object sender, EventArgs e)
        {
            try
            {

            
            StreamWriter outputFile;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //Open the file for appending,
                    //and get a StreamWriter object.
                    outputFile = File.AppendText(saveFile.FileName);

                    //Write data to the file
                    outputFile.Write(result_textBox.Text);

                    //Close the file.
                    outputFile.Close();

                    //Let the user know the data was written to the file
                    MessageBox.Show("The data has been written and saved.");

                    //Clear both text box controls
                    listOfWords_txtbox.Clear();
                    result_textBox.Clear();
                }
                else
                {
                   MessageBox.Show("You clicked the cancel button.");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
