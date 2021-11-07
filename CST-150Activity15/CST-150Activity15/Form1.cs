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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void submitLucky_btn_Click(object sender, EventArgs e)  //upon clicking the sumbit button
        {
            Random r = new Random();                     //create the random object memory address
            int low = ((int)lowNum_ud.Value);          
            int high = ((int)highNum_ud.Value);

            int luckyNumber = r.Next(low, high);          //assigns the user's lucky number as an int between the high and low value

            Form2 form2 = new Form2();                 //creates and instance of the second form
            this.Hide();                               //hides Form1
            form2.populateLuckyNum(luckyNumber);       //generates a rnadom number in Form2's textbox with the populateLuckyNum()
            form2.Show();                             //displays to the user, Form2 while Form1 is hidden.
            
            
        }
    }
}
