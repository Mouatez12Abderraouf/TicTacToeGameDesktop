using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGameDesktop.Properties;

namespace TicTacToeGameDesktop
{

    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(color, 8);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Vertical line
            e.Graphics.DrawLine(pen, 350, 60, 350, 420);
            e.Graphics.DrawLine(pen, 490, 60, 490, 420);

            // draw Horizontal line
            e.Graphics.DrawLine(pen, 230, 170, 610, 170);
            e.Graphics.DrawLine(pen, 230, 300, 610, 300);



        }

        private void changeButtonColor(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.Green;
            btn2.BackColor = Color.Green;
            btn3.BackColor = Color.Green;
        }

        private bool isWin()
        {
            if (arr[0] == arr[1] && arr[1] == arr[2] && arr[0] != ' ')
            {
                changeButtonColor(button1, button2, button3);

                return true;
            }

            if (arr[3] == arr[4] && arr[4] == arr[5] && arr[5] != ' ')
            {
                changeButtonColor(button4, button5, button6);

                return true;
            }

            if (arr[6] == arr[7] && arr[7] == arr[8] && arr[6] != ' ')
            {

                changeButtonColor(button7, button8, button9);

                return true;
            }

            if (arr[0] == arr[3] && arr[3] == arr[6] && arr[3] != ' ')
            {
                changeButtonColor(button1, button4, button7);

                return true;
            }

            if (arr[1] == arr[4] && arr[4] == arr[7] && arr[4] != ' ')
            {
                changeButtonColor(button2, button5, button8);
              
                return true;
            }

            if (arr[2] == arr[5] && arr[5] == arr[8] && arr[8] != ' ')
            {
                changeButtonColor(button3, button6, button9); 

                return true;
            }

            if (arr[0] == arr[4] && arr[4] == arr[8] && arr[0] != ' ')
            {
                changeButtonColor(button1, button5, button9);
           
                return true;
            }

            if (arr[2] == arr[4] && arr[4] == arr[6] && arr[2] != ' ')
            {
                changeButtonColor(button3, button5, button7);
          
                return true;
            }

            return false;
        }

        private bool isDraw()
        {
            for(short i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                    return false;
            }

            return true;
        }

        

        private void AdaptMove(Button sender)
        {
            if (arr[Convert.ToInt16(sender.Tag.ToString())] == ' ')
            {
                if (labTurn.Text == "Player 1")
                {
                    arr[Convert.ToInt16(sender.Tag.ToString())] = 'X';
                    sender.Image = Resources.X;
                    if (isWin())
                    {
                        labTurn.Text = "Game Over";
                        labWinner.Text = "   Player 1";
                        MessageBox.Show("Game Over");
                    }
                    else if (isDraw())
                    {
                        labTurn.Text = "Game Over";
                        labWinner.Text = "     Draw";
                        MessageBox.Show("Game Over");
                    }
                    else
                    {
                        labTurn.Text = "Player 2";
                    }
                }
                else
                {
                    arr[Convert.ToInt16(sender.Tag.ToString())] = 'O';
                    sender.Image = Resources.O;
                    if (isWin())
                    {
                        labTurn.Text = "Game Over";
                        labWinner.Text = "   Player 2";
                        MessageBox.Show("Game Over");
                    }
                    else if (isDraw())
                    {
                        labTurn.Text = "Game Over";
                        labWinner.Text = "     Draw";
                        MessageBox.Show("Game Over");
                    }
                    else
                    {
                        labTurn.Text = "Player 1";
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!isWin())
                AdaptMove((Button)sender);
        }


        private void RestartGame(Button btn1,  Button btn2, Button btn3)
        {
            btn1.Image = Properties.Resources.question_mark_96;
            btn2.Image = Properties.Resources.question_mark_96;
            btn3.Image = Properties.Resources.question_mark_96;

            btn1.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn2.BackColor = Color.Black;

        }


        private void btnRestartGame_Click_1(object sender, EventArgs e)
        {
            RestartGame(button1, button2, button3);
            RestartGame(button4, button5, button6);
            RestartGame(button7, button8, button9);

            labTurn.Text = "Player 1";
            labWinner.Text = "In progress";

            for (short i = 0; i < arr.Length; i++)
            {
                arr[i] = ' ';
            }
        }
    }
}
