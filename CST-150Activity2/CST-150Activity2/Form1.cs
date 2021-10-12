using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conversionAction_btn_Click(object sender, EventArgs e)
        {
            // Exception Handler try/catch
            try
            {


                //Gets the value of the input from the textbox
                string fahrenheitInput = fahrenheitValueInput_txtbox.Text.ToString();



                /*
                 * Mathematical conversion of the textbox input value from a Fahrenheit
                 * temperature to Celsius temperature
                 */
                double celsiusResult = (5.0 / 9) * (double.Parse(fahrenheitInput) - 32);

                //set new value to the celsius result textbox
                //format the ToString to display three decimal places
                celsiusValue_txtbox.Text = celsiusResult.ToString("#.000");

                MessageBox.Show("Your conversion is complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
