using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBangRoshambo
{
    public partial class Form1 : Form
    {
        int Wins = 0, Loses = 0, Ties = 0, PlayerSign = 9;
        Random ranSign = new Random();
        Bitmap iRock = new Bitmap("Rock.jpg");
        Bitmap iPaper = new Bitmap("Paper.jpg");
        Bitmap iScissor = new Bitmap("Scissor.jpg");
        Bitmap iLizard = new Bitmap("Lizard.png");
        Bitmap iSpock = new Bitmap("Spock.png");

        public Form1()
        {
            InitializeComponent();
        }

        private void rdoEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEasy.Checked == true)
            {
                rdoHard.Checked = false;
                picLizard.Visible = false;
                picSpock.Visible = false;
            }
        }

        private void rdoHard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHard.Checked == true)
            {
                rdoEasy.Checked = false;
                picLizard.Visible = true;
                picSpock.Visible = true;
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (rdoEasy.Checked == true)
            {
                rdoPaper.Visible = true;
                rdoRock.Visible = true;
                rdoScissor.Visible = true;
            }
            else if (rdoHard.Checked == true)
            {
                rdoPaper.Visible = true;
                rdoRock.Visible = true;
                rdoScissor.Visible = true;
                rdoLizard.Visible = true;
                rdoSpock.Visible = true;
            }
            lblWins.Text = Convert.ToString(Wins);
            lblLoses.Text = Convert.ToString(Loses);
            lblTies.Text = Convert.ToString(Ties);
            rdoEasy.Visible = false;
            rdoHard.Visible = false;
            btnBegin.Enabled = false;
            btnFight.Enabled = true;
            btnChange.Enabled = true;
        }

        private void rdoRock_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRock.Checked == true)
            {
                rdoPaper.Checked = false;
                rdoScissor.Checked = false;
                rdoLizard.Checked = false;
                rdoSpock.Checked = false;
            }
            PlayerSign = 0;
        }

        private void rdoPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPaper.Checked == true)
            {
                rdoRock.Checked = false;
                rdoScissor.Checked = false;
                rdoLizard.Checked = false;
                rdoSpock.Checked = false;
            }
            PlayerSign = 1;
        }

        private void rdoScissor_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoScissor.Checked == true)
            {
                rdoRock.Checked = false;
                rdoPaper.Checked = false;
                rdoLizard.Checked = false;
                rdoSpock.Checked = false;
            }
            PlayerSign = 2;
        }

        private void rdoLizard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLizard.Checked == true)
            {
                rdoRock.Checked = false;
                rdoPaper.Checked = false;
                rdoScissor.Checked = false;
                rdoSpock.Checked = false;
            }
            PlayerSign = 3;
        }

        private void rdoSpock_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSpock.Checked == true)
            {
                rdoRock.Checked = false;
                rdoPaper.Checked = false;
                rdoScissor.Checked = false;
                rdoLizard.Checked = false;
            }
            PlayerSign = 4;
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            string EnemySign = "";
            int EnemyThrow = 9;

            if (rdoEasy.Checked == true)
            {
                EnemyThrow = ranSign.Next(3);
                switch (EnemyThrow)
                {
                    case 0:
                        EnemySign = "Rock";
                        picVSThrow.BackgroundImage = iRock;
                        break;
                    case 1:
                        EnemySign = "Paper";
                        picVSThrow.BackgroundImage = iPaper;
                        break;
                    case 2:
                        EnemySign = "Scissors";
                        picVSThrow.BackgroundImage = iScissor;
                        break;
                }
            }
            else if (rdoHard.Checked == true)
            {
                EnemyThrow = ranSign.Next(5);
                switch (EnemyThrow)
                {
                    case 0:
                        EnemySign = "Rock";
                        picVSThrow.BackgroundImage = iRock;
                        break;
                    case 1:
                        EnemySign = "Paper";
                        picVSThrow.BackgroundImage = iPaper;
                        break;
                    case 2:
                        EnemySign = "Scissors";
                        picVSThrow.BackgroundImage = iScissor;
                        break;
                    case 3:
                        EnemySign = "Lizard";
                        picVSThrow.BackgroundImage = iLizard;
                        break;
                    case 4:
                        EnemySign = "Spock";
                        picVSThrow.BackgroundImage = iSpock;
                        break;
                }
            }        

            switch (PlayerSign)
            {
                case 0:
                    if (EnemyThrow == 2 || EnemyThrow == 3)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You win!";
                        Wins++;
                        lblWins.Text = Convert.ToString(Wins);
                        rdoRock.Checked = false;
                    }
                    else if (EnemyThrow == 1 || EnemyThrow == 4)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You lose!";
                        Loses++;
                        lblLoses.Text = Convert.ToString(Loses);
                        rdoRock.Checked = false;
                    }
                    else if (EnemyThrow == 0)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! It's a tie!";
                        Ties++;
                        lblTies.Text = Convert.ToString(Ties);
                        rdoRock.Checked = false;
                    }
                    break;
                case 1:
                    if (EnemyThrow == 0 || EnemyThrow == 4)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You win!";
                        Wins++;
                        lblWins.Text = Convert.ToString(Wins);
                        rdoPaper.Checked = false;
                    }
                    else if (EnemyThrow == 2 || EnemyThrow == 3)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You lose!";
                        Loses++;
                        lblLoses.Text = Convert.ToString(Loses);
                        rdoPaper.Checked = false;
                    }
                    else if (EnemyThrow == 1)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! It's a tie!";
                        Ties++;
                        lblTies.Text = Convert.ToString(Ties);
                        rdoPaper.Checked = false;
                    }
                    break;
                case 2:
                    if (EnemyThrow == 1 || EnemyThrow == 3)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You win!";
                        Wins++;
                        lblWins.Text = Convert.ToString(Wins);
                        rdoScissor.Checked = false;
                    }
                    else if (EnemyThrow == 0 || EnemyThrow == 4)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You lose!";
                        Loses++;
                        lblLoses.Text = Convert.ToString(Loses);
                        rdoScissor.Checked = false;
                    }
                    else if(EnemyThrow == 2)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! It's a tie!";
                        Ties++;
                        lblTies.Text = Convert.ToString(Ties);
                        rdoScissor.Checked = false;
                    }
                    break;
                case 3:
                    if (EnemyThrow == 1 || EnemyThrow == 4)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You win!";
                        Wins++;
                        lblWins.Text = Convert.ToString(Wins);
                        rdoLizard.Checked = false;
                    }
                    else if (EnemyThrow == 0 || EnemyThrow == 2)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You lose!";
                        Loses++;
                        lblLoses.Text = Convert.ToString(Loses);
                        rdoLizard.Checked = false;
                    }
                    else if (EnemyThrow == 3)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! It's a tie!";
                        Ties++;
                        lblTies.Text = Convert.ToString(Ties);
                        rdoLizard.Checked = false;
                    }
                    break;
                case 4:
                    if (EnemyThrow == 0 || EnemyThrow == 2)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You win!";
                        Wins++;
                        lblWins.Text = Convert.ToString(Wins);
                        rdoSpock.Checked = false;
                    }
                    else if (EnemyThrow == 1 || EnemyThrow == 3)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! You lose!";
                        Loses++;
                        lblLoses.Text = Convert.ToString(Loses);
                        rdoSpock.Checked = false;
                    }
                    else if (EnemyThrow == 4)
                    {
                        lblOpponent.Text = "The opponent throws " + EnemySign + "! It's a tie!";
                        Ties++;
                        lblTies.Text = Convert.ToString(Ties);
                        rdoSpock.Checked = false;
                    }
                    break;
                default:
                    lblOpponent.Text = "An error occured or no Sign selected to throw.";
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            rdoPaper.Visible = false;
            rdoRock.Visible = false;
            rdoScissor.Visible = false;
            rdoLizard.Visible = false;
            picLizard.Visible = false;
            rdoSpock.Visible = false;
            picSpock.Visible = false;
            rdoEasy.Visible = true;
            rdoHard.Visible = true;
            btnBegin.Enabled = true;
        }
    }
}
