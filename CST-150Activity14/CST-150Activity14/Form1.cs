using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            //puts CharacterName in the lower TextBox
            output_txtbox.Text = "Character Name: " + charName_txtbox.Text + Environment.NewLine;

            //checks through questions and gets their answered values
            //Question 1 check
            if (q1Option1_radiobtn.Checked == true)
                output_txtbox.AppendText("Class: " + q1Option1_radiobtn.Text + Environment.NewLine);
            else if (q1Option2_radiobtn.Checked == true)
                output_txtbox.AppendText("Class: " + q1Option2_radiobtn.Text + Environment.NewLine);
            else if (q1Option3_radiobtn.Checked == true)
                output_txtbox.AppendText("Class: " + q1Option3_radiobtn.Text + Environment.NewLine);
            else if (q1Option4_radiobtn.Checked == true)
                output_txtbox.AppendText("Class: " + q1Option4_radiobtn.Text + Environment.NewLine);
            else if (q1Option5_radiobtn.Checked == true)
                output_txtbox.AppendText("Class: " + q1Option5_radiobtn.Text + Environment.NewLine);
            //Question 2 check
            if (q2Option1_chkbox.Checked == true)
                output_txtbox.AppendText("Genre: " + q2Option1_chkbox.Text + Environment.NewLine);
            if (q2Option2_chkbox.Checked == true)
                output_txtbox.AppendText("Genre: " + q2Option2_chkbox.Text + Environment.NewLine);
            if (q2Option3_chkbox.Checked == true)
                output_txtbox.AppendText("Genre: " + q2Option3_chkbox.Text + Environment.NewLine);
            if (q2Option4_chkbox.Checked == true)
                output_txtbox.AppendText("Genre: " + q2Option4_chkbox.Text + Environment.NewLine);
            if (q2Option5_chkbox.Checked == true)
                output_txtbox.AppendText("Genre: " + q2Option5_chkbox.Text + Environment.NewLine);
            //Question 3 check
            if (q3Option1_radiobtn.Checked == true)
                output_txtbox.AppendText("Race: " + q3Option1_radiobtn.Text + Environment.NewLine);
            else if (q3Option2_radiobtn.Checked == true)
                output_txtbox.AppendText("Race: " + q3Option2_radiobtn.Text + Environment.NewLine);
            else if (q3Option3_radiobtn.Checked == true)
                output_txtbox.AppendText("Race: " + q3Option3_radiobtn.Text + Environment.NewLine);
            else if (q3Option4_radiobtn.Checked == true)
                output_txtbox.AppendText("Race: " + q3Option4_radiobtn.Text + Environment.NewLine);
            else if (q3Option5_radiobtn.Checked == true)
                output_txtbox.AppendText("Race: " + q3Option5_radiobtn.Text + Environment.NewLine);
            //Question 4 check
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object inventoryItems in q4listBox.Items)
            {
                sb.Append(inventoryItems.ToString());
                sb.Append(" ");
            }
            output_txtbox.AppendText("Inventory items: " + sb.ToString());
        }

        private void q4addItem_btn_Click(object sender, EventArgs e)
        {
            //puts the text from addItem_txtbox into the listBox control.
            q4listBox.Items.Add(q4Item_txtbox.Text);
            q4Item_txtbox.Clear();
        }
    }
}
