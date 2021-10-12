using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculatePi_btn_Click(object sender, EventArgs e)
        {
            
            decimal fraction = 3;                              //holds decimal value for calcualtion
            string numberOfTerms = numberOfTermsInput_txtbox.Text;  //holds user input from the textbox
            int termsAsInt = Convert.ToInt32(numberOfTerms);        //converts the user input into an int datatype
            decimal calculationResult = 0;                                   //holds the value for the calculation result

            for (int count = 1; count <= termsAsInt; count++)            //loop or iterates through the number of terms provided by user
            {
                if (count == 1)                        //calcualtion starts
                {
                    calculationResult = 4;
                }
                else if (count % 2 == 0)                    
                {
                    calculationResult = calculationResult - (4 / fraction);
                    fraction = fraction + 2;
                }
                else if (count != 1 && count % 2 != 0)
                {
                    calculationResult = calculationResult + (4 / fraction);
                    fraction = fraction + 2;         //calculation ends
                }
            }

            //display results to the labels at the bottom of the app window
            termInputAprroxValue_lbl.Text = "Approximate value of pi after " + termsAsInt + " terms";
            calculationResult_lbl.Text = "= " + calculationResult.ToString("#.00000000000000");

        }
    }
}
