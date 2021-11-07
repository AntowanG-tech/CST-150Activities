using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();    //creates new form 1
            this.Close();                //closes the form 2
            form1.Show();                //displays form 1 to the user
        }

        public void populateLuckyNum(int luckyNum)
        {
            userLuckyNum_txtbox.Text = luckyNum.ToString();   //method sets the textbox in the second form (Form2.cs)
        }
    }
}
