using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class FrmMain : Form
    {
        Random randomNumber = new Random();

        enum Selection { ROCK, PAPER, SCISSORS};
        Selection PlayerChoice, ComputerChoice;

        int PlayerScore, ComputerScore, TieScore;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayerChoice = Selection.ROCK;
            DoComparisons();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayerChoice = Selection.PAPER;
            DoComparisons();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayerChoice = Selection.SCISSORS;
            DoComparisons();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Player Chose:";
            lblComputerChoice.Text = "Computer Chose:";
            lblResult.ForeColor = System.Drawing.Color.Black;
            lblResult.Text = "Result:";

            PlayerScore = 0;
            ComputerScore = 0;
            TieScore = 0;

            txtPlayerWins.Text = Convert.ToString(PlayerScore);
            txtComputerWins.Text = Convert.ToString(ComputerScore);
            txtTieWins.Text = Convert.ToString(TieScore);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PlayerScore = 0;
            ComputerScore = 0;
            TieScore = 0;
        }

        private void DoComparisons()
        {
            ComputerChoice = (Selection)randomNumber.Next(0, 3);
            lblPlayerChoice.Text = "Player Chose: " + Convert.ToString((Selection)PlayerChoice);
            lblComputerChoice.Text = "Computer Chose: " + Convert.ToString((Selection)ComputerChoice);

            // Selections that result in a tie.
            if (PlayerChoice == ComputerChoice)
            {
                lblResult.ForeColor = System.Drawing.Color.Black;
                lblResult.Text = "Tie";
                TieScore++;
            }
            else
            {
                // Selections that result in Player win
                if ((PlayerChoice == Selection.ROCK && ComputerChoice == Selection.SCISSORS) ||
                    (PlayerChoice == Selection.PAPER && ComputerChoice == Selection.ROCK) ||
                    (PlayerChoice == Selection.SCISSORS && ComputerChoice == Selection.PAPER))
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Player Wins!";
                    PlayerScore++;
                }
                //Selections that result in Computer win
                else
                {
                    lblResult.ForeColor = System.Drawing.Color.Red;
                    lblResult.Text = "Computer Wins!";
                    ComputerScore++;
                }
            }

            txtPlayerWins.Text = Convert.ToString(PlayerScore);
            txtComputerWins.Text = Convert.ToString(ComputerScore);
            txtTieWins.Text = Convert.ToString(TieScore);
        }
    }
}
