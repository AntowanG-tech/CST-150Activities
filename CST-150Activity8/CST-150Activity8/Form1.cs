using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables
                int fatCalculated;
                string userInput = caloriesFromFat_txtbox.Text.ToString();        //textbox takes user input
                int fatGrams = Convert.ToInt32(userInput);                        //converts user input to an int

                //calculate calories from fat
                fatCalculated = fatGrams * 9;

                //puts result value (fatCalculated) in result_lbl
                caloriesFromFatResult_lbl.Text = "= " + fatCalculated + " calories from fat.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateFromCarbs_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables
                int carbsCalculated;
                string userInput = caloriesFromCarbs_txtbox.Text.ToString();        //textbox takes user input
                int carbGrams = Convert.ToInt32(userInput);                        //converts user input to an int

                //calculate calories from carbs
                carbsCalculated = carbGrams * 4;

                //puts result value (carbsCalculated) in result_lbl
                caloriesFromCarbsResult_lbl.Text = "= " + carbsCalculated + " calories from carbs.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
