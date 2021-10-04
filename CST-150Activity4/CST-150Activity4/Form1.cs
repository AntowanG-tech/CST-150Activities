using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timeConversion_btn_Click(object sender, EventArgs e)
        {
            //identify the needed variables for time conversion
            int secondsInput;             //To hold seconds input by user
            int seconds = 0;                  //To hold seconds elapsed
            int minutes = 0;                  //To hold minutes elapsed
            int hours = 0;                    //To hold hours elapsed
            int days = 0;                     //To hold days elapsed
            int timeRemainAfterDays;       //To hold reamaining time after days calculation
            int timeRemainAfterHours;     //To hold reamaining time after hours calculation

            //Validate the secondsInput_txtBox control
            if (int.TryParse(SecondsInput_txtBox.Text, out secondsInput))
            {
                //Check days if user input is greater than or equal to 86,400
                if (secondsInput >= 86400 || secondsInput >= 3600 || secondsInput >= 60)
                {
                    days = secondsInput / 86400;
                    timeRemainAfterDays = secondsInput % 86400;

                    //uses the remainder from days calculation to check for hours
                    if (timeRemainAfterDays >= 3600)
                    {
                        //calculate hours and time remaining afterward
                        hours = timeRemainAfterDays / 3600;
                        timeRemainAfterHours = timeRemainAfterDays % 3600;

                        //uses the remainder from hours calculation to check for mins and  left over seconds
                        if (timeRemainAfterHours >= 60)
                        {
                            minutes = timeRemainAfterHours / 60;
                            seconds = timeRemainAfterHours % 60;
                        }
                        else
                        {
                            seconds = timeRemainAfterHours;
                        }
                    }

                    //checks timeRemainAfterDays for minutes
                    else if (timeRemainAfterDays >= 60)
                    {
                        minutes = timeRemainAfterDays / 60;
                        seconds = timeRemainAfterDays % 60;

                    }
                    //checks timeRemainAfterDays for seconds
                    else
                    {
                        seconds = timeRemainAfterDays;
                    }
                }
                
                //create string for time format D : HH: MM: SS
                timeResultLabel.Text = days.ToString() + ":" + hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
               

                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }

        }

       
    }
}
