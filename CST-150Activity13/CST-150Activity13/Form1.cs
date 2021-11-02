using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150Activity13
{
    public partial class Form1 : Form
    {
        //true = X turn; false = Y turn;
        bool turn = true;
        int turn_count = 0;
        int [,] labelGrid =
        {
            {0,0,0},
            {0,0,0},
            {0,0,0}
        };

        int posX;
        int posY;         //left off 0120 on 20211101

        public Form1()
        {
            InitializeComponent();
        }

        private void exitGame_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_click(object sender, EventArgs e)
        {
            Label l = (Label)sender;

            //Map buttons to positions on game grid.
            if (l == topLeft_lbl)
            {
                posY = 0;
                posX = 0;

                playerValueOnGrid(posY, posX);
            }
            else if (l == topCenter_lbl)
            {
                posY = 0;
                posX = 1;

                playerValueOnGrid(posY, posX);
            }
            else if (l == topRight_lbl)
            {
                posY = 0;
                posX = 2;

                playerValueOnGrid(posY, posX);
            }
            else if (l == centerLeft_lbl)
            {
                posY = 1;
                posX = 0;

                playerValueOnGrid(posY, posX);
            }
            else if (l == center_lbl)
            {
                posY = 1;
                posX = 1;

                playerValueOnGrid(posY, posX);
            }
            else if (l == centerRight_lbl)
            {
                posY = 1;
                posX = 2;

                playerValueOnGrid(posY, posX);
            }
            else if (l == bottomLeft_lbl)
            {
                posY = 2;
                posX = 0;

                playerValueOnGrid(posY, posX);
            }
            else if (l == bottomCenter_lbl)
            {
                posY = 2;
                posX = 1;

                playerValueOnGrid(posY, posX);
            }
            else if (l == bottomRight_lbl)
            {
                posY = 2;
                posX = 2;

                playerValueOnGrid(posY, posX);
            }

            if (turn == true)
            {
                l.Text = "X";
         
            }
            else
            {
                l.Text = "O";
            }

            turn = !turn;
            l.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool winnerExists = false;


            // horizontal winning conditions
            if (labelGrid[0, 0] == 1 && labelGrid[0, 1] == 1 && labelGrid[0, 2] == 1 || labelGrid[0, 0] == 2 && labelGrid[0, 1] == 2 && labelGrid[0, 2] == 2) 
                winnerExists = true;
            else if (labelGrid[1, 0] == 1 && labelGrid[1, 1] == 1 && labelGrid[1, 2] == 1 || labelGrid[1, 0] == 2 && labelGrid[1, 1] == 2 && labelGrid[1, 2] == 2)
                winnerExists = true;
            else if (labelGrid[2, 0] == 1 && labelGrid[2, 1] == 1 && labelGrid[2, 2] == 1 || labelGrid[2, 0] == 2 && labelGrid[2, 1] == 2 && labelGrid[2, 2] == 2)
                winnerExists = true;
            //vertical winning conditions
           else if (labelGrid[0, 0] == 1 && labelGrid[1, 0] == 1 && labelGrid[2, 0] == 1 || labelGrid[0, 0] == 2 && labelGrid[1, 0] == 2 && labelGrid[2, 0] == 2)
                winnerExists = true;
            else if (labelGrid[0, 1] == 1 && labelGrid[1, 1] == 1 && labelGrid[2, 1] == 1 || labelGrid[0, 1] == 2 && labelGrid[1, 1] == 2 && labelGrid[2, 1] == 2)
                winnerExists = true;
            else if (labelGrid[0, 2] == 1 && labelGrid[1, 2] == 1 && labelGrid[2, 2] == 1 || labelGrid[0, 2] == 2 && labelGrid[1, 2] == 2 && labelGrid[2, 2] == 2)
                winnerExists = true;
            //diagonal winning conditions
            else if (labelGrid[0, 0] == 1 && labelGrid[1, 1] == 1 && labelGrid[2, 2] == 1 || labelGrid[0, 0] == 2 && labelGrid[1, 1] == 2 && labelGrid[2, 2] == 2)
                winnerExists = true;
            else if (labelGrid[0, 2] == 1 && labelGrid[1, 1] == 1 && labelGrid[2, 0] == 1 || labelGrid[0, 2] == 2 && labelGrid[1, 1] == 2 && labelGrid[2, 0] == 2)
                winnerExists = true;
            /**
            //horizontal winning conditions
            if ((topLeft_lbl.Text == topCenter_lbl.Text) && (topCenter_lbl.Text == topRight_lbl.Text) && (!topLeft_lbl.Enabled))
                winnerExists = true;
           else if ((centerLeft_lbl.Text == center_lbl.Text) && (center_lbl.Text == centerRight_lbl.Text) && (!centerLeft_lbl.Enabled))
                winnerExists = true;
           else if ((bottomLeft_lbl.Text == bottomCenter_lbl.Text) && (bottomCenter_lbl.Text == bottomRight_lbl.Text) && (!bottomLeft_lbl.Enabled))
                winnerExists = true;
            //vertical winning conditions
           else if ((topLeft_lbl.Text == centerLeft_lbl.Text) && (centerLeft_lbl.Text == bottomLeft_lbl.Text) && (!topLeft_lbl.Enabled))
                winnerExists = true;
           else if ((topCenter_lbl.Text == center_lbl.Text) && (center_lbl.Text == bottomCenter_lbl.Text) && (!topCenter_lbl.Enabled))
                winnerExists = true;
           else if ((topRight_lbl.Text == centerRight_lbl.Text) && (centerRight_lbl.Text == bottomRight_lbl.Text) && (!topRight_lbl.Enabled))
                winnerExists = true;
            //diagonal winning conditions
           else if ((topLeft_lbl.Text == center_lbl.Text) && (center_lbl.Text == bottomRight_lbl.Text) && (!topLeft_lbl.Enabled))
                winnerExists = true;
           else if ((topRight_lbl.Text == center_lbl.Text) && (center_lbl.Text == bottomLeft_lbl.Text) && (!bottomLeft_lbl.Enabled))
                winnerExists = true;
            */


            //shows the winner of the game in the lower label box of the form
            if (winnerExists)
            {
                disableButtons();

                String winner = "";
                if(turn == true)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }

                declareWinner_lbl.Text = "Player " + "'" + winner + "' " + "is the winner!";
            }
            else
            {
                if (turn_count == 9)
                {
                    declareWinner_lbl.Text = "Looks like there is no winner. It was a draw!";
                }
            }
        }

        private void disableButtons()
        {
            try
            {


                foreach (Label c in Controls)
                {
                    
                    Label l = (Label)c;
                    l.Enabled = false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newGame_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
           

        }

        //marks grid with player value where players make moves
        private void playerValueOnGrid(int posY, int posX)
        {
            //if X turn 
            if(turn == true)
            {
                //change value on the game grid (2dArray) with 1 signifying player 'X'
                labelGrid[posY, posX] = 1;
                //connects the player value to the label on the game
                String labelPosition = "The position of the X is [" + posY + ", " + posX + "]";
                Console.WriteLine(labelPosition);

            }
            else
            {
                //On O's turn place the player value in the 2dArray with 2 signifying player 'O'
                if (turn == false)
                {
                    labelGrid[posY, posX] = 2;
                    //connects the player value to the label on the game
                    String labelPosition = "The position of the O is [" + posY + ", " + posX + "]";
                    Console.WriteLine(labelPosition);
                }
            }
        }
    }
}
