using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Form_App
{
    public partial class Form1 : Form
    {
        int selection = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            selection = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            selection = 2;

        }

        private void label3_Click(object sender, EventArgs e)
        {

            selection = 3;
        }

        private void label4_Click(object sender, EventArgs e)
        {

            selection = 4;
        }

        private void label5_Click(object sender, EventArgs e)
        {

            selection = 5;
        }

        private void label8_Click(object sender, EventArgs e)
        {

            selection = 6;
        }

        private void label6_Click(object sender, EventArgs e)
        {

            selection = 7;
        }

        private void label7_Click(object sender, EventArgs e)
        {

            selection = 8;
        }

        private void label9_Click(object sender, EventArgs e)
        {

            selection = 9;
        }

        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            int begin = rnd.Next(2);
            if (begin == 0)
            {
                cmdSetX.Enabled = true;
                cmdSetO.Enabled = false;
                lblGameState.Text = "Neues Spiel beginnt. X an der Reihe...";
            }
            else
            {
                cmdSetO.Enabled = true;
                cmdSetX.Enabled = false;
                lblGameState.Text = "Neues Spiel beginnt. O an der Reihe...";
            }
            label1.Text = "1";
            label2.Text = "2";
            label3.Text = "3";
            label4.Text = "4";
            label5.Text = "5";
            label8.Text = "6";
            label6.Text = "7";
            label7.Text = "8";
            label9.Text = "9";
        }

        private void cmdSetO_Click(object sender, EventArgs e)
        {

            cmdSetX.Enabled = true;
            cmdSetO.Enabled = false;
            lblGameState.Text = "Spiel läuft. X an der Reihe...";
            switch (selection)
            {
                case 1:
                    if (label1.Text != "O" && label1.Text != "X")
                    {
                        label1.Text = "O";
                        if((label2.Text == "O" && label3.Text == "O") || (label5.Text == "O" && label9.Text == "O") || (label4.Text == "O" && label6.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 2:
                    if (label2.Text != "O" && label2.Text != "X")
                    {
                        label2.Text = "O";
                        if ((label1.Text == "O" && label3.Text == "O") || (label5.Text == "O" && label7.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 3:
                    if (label3.Text != "O" && label3.Text != "X")
                    {
                        label3.Text = "O";
                        if ((label2.Text == "O" && label1.Text == "O") || (label8.Text == "O" && label9.Text == "O") || (label5.Text == "O" && label6.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 4:
                    if (label4.Text != "O" && label4.Text != "X")
                    {
                        label4.Text = "O";
                        if ((label5.Text == "O" && label8.Text == "O") || (label1.Text == "O" && label6.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 5:
                    if (label5.Text != "O" && label5.Text != "X")
                    {
                        label5.Text = "O";
                        if ((label2.Text == "O" && label7.Text == "O") || (label4.Text == "O" && label8.Text == "O") || (label1.Text == "O" && label9.Text == "O") || (label3.Text == "O" && label6.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 6:
                    if (label8.Text != "O" && label8.Text != "X")
                    {
                        label8.Text = "O";
                        if ((label4.Text == "O" && label5.Text == "O") || (label3.Text == "O" && label9.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 7:
                    if (label6.Text != "O" && label6.Text != "X")
                    {
                        label6.Text = "O";
                        if ((label1.Text == "O" && label4.Text == "O") || (label5.Text == "O" && label3.Text == "O") || (label7.Text == "O" && label9.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 8:
                    if (label7.Text != "O" && label7.Text != "X")
                    {
                        label7.Text = "O";
                        if ((label2.Text == "O" && label5.Text == "O") || (label6.Text == "O" && label9.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                case 9:
                    if (label9.Text != "O" && label9.Text != "X")
                    {
                        label9.Text = "O";
                        if ((label7.Text == "O" && label6.Text == "O") || (label3.Text == "O" && label8.Text == "O") || (label1.Text == "O" && label5.Text == "O"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. O hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetO.Enabled = true;
                        cmdSetX.Enabled = false;
                        lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    }
                    break;
                default:
                    cmdSetO.Enabled = true;
                    cmdSetX.Enabled = false;
                    lblGameState.Text = "Spiel läuft. O an der Reihe...";
                    break;
            }
            isRemis();
        }

        private void cmdSetX_Click(object sender, EventArgs e)
        {
            cmdSetO.Enabled = true;
            cmdSetX.Enabled = false;
            lblGameState.Text = "Spiel läuft. O an der Reihe...";
            switch (selection)
            {
                case 1:
                    if (label1.Text != "O" && label1.Text != "X")
                    {
                        label1.Text = "X";
                        if ((label2.Text == "X" && label3.Text == "X") || (label5.Text == "X" && label9.Text == "X") || (label4.Text == "X" && label6.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 2:
                    if (label2.Text != "O" && label2.Text != "X") {
                        label2.Text = "X";
                        if ((label1.Text == "X" && label3.Text == "X") || (label5.Text == "X" && label7.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 3:
                    if (label3.Text != "O" && label3.Text != "X") {
                        label3.Text = "X";
                        if ((label2.Text == "X" && label1.Text == "X") || (label5.Text == "X" && label6.Text == "X") || (label8.Text == "X" && label9.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 4:
                    if (label4.Text != "O" && label4.Text != "X") {
                        label4.Text = "X";
                        if ((label1.Text == "X" && label6.Text == "X") || (label5.Text == "X" && label8.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 5:
                    if (label5.Text != "O" && label5.Text != "X") {
                        label5.Text = "X";
                        if ((label2.Text == "X" && label7.Text == "X") || (label1.Text == "X" && label9.Text == "X") || (label4.Text == "X" && label8.Text == "X") || (label3.Text == "X" && label6.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 6:
                    if (label8.Text != "O" && label8.Text != "X") {
                        label8.Text = "X";
                        if ((label4.Text == "X" && label5.Text == "X") || (label3.Text == "X" && label9.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 7:
                    if (label6.Text != "O" && label6.Text != "X") {
                        label6.Text = "X";
                        if ((label1.Text == "X" && label4.Text == "X") || (label5.Text == "X" && label3.Text == "X") || (label7.Text == "X" && label9.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 8:
                    if (label7.Text != "O" && label7.Text != "X") {
                        label7.Text = "X";
                        if ((label2.Text == "X" && label5.Text == "X") || (label6.Text == "X" && label9.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    } 
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                case 9:
                    if (label9.Text != "O" && label9.Text != "X") { 
                        label9.Text = "X";
                        if ((label8.Text == "X" && label3.Text == "X") || (label5.Text == "X" && label1.Text == "X") || (label6.Text == "X" && label7.Text == "X"))
                        {
                            cmdSetO.Enabled = false;
                            cmdSetX.Enabled = false;
                            lblGameState.Text = "Spiel zu Ende. X hat 3 in einer Reihe!";
                        }
                    }
                    else
                    {
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    }
                    break;
                default:                    
                        cmdSetX.Enabled = true;
                        cmdSetO.Enabled = false;
                        lblGameState.Text = "Spiel läuft. X an der Reihe...";
                    break;
            }
            isRemis();
        }
        private void isRemis()
        {
            if(label1.Text != "1" && label2.Text != "2" && label3.Text != "3" && label4.Text != "4" && label5.Text != "5" && label6.Text != "7" && label7.Text != "8" && label8.Text != "6" && label9.Text != "9")
            {
                lblGameState.Text = "Spiel zu Ende. Unentschieden.";
                cmdSetO.Enabled = false;
                cmdSetX.Enabled = false;
            }
        }
    }
}
