using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String firstName = firstName_txtbox.Text.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void showFullName_btn_Click(object sender, EventArgs e)
        {
            String firstName = firstName_txtbox.Text.ToString();
            String lastName = lastName_txtbox.Text.ToString();
            String date = dateTimePicker1.ToString();
            MessageBox.Show("Your full name is: " + firstName + " " + lastName + "!" + Environment.NewLine
                 + "The Date Recorded: " + dateTimePicker1);
        }
    }
}
