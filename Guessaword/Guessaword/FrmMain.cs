using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace Guessaword
{
    public partial class FrmMain : Form
    {
        SoundPlayer tada = new SoundPlayer(Guessaword.Properties.Resources.tada);
        Random RandomNumber = new Random();

        string[] words = { "average", "pineapple", "express", "robot", "zebra",
        "highway", "knuckle", "chocolate", "monitor", "dragon", "programming",
        "flabbergasted", "supercalifragilisticexpialidocious", "peptide", "membrane",
        "superstitious", "jazz", "calculator", "machine", "quilt", "pillow", "mittens",
        "garbage", "tote", "pillar" };

        string word;
        string hiddenword;
        int countTries;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            letterEntered();
        }

        private void letterEntered()
        {
            string myLetter;
            char[] arrayHiddenWord = hiddenword.ToCharArray();
            myLetter = txtGuess.Text;

            if (lblUsedletters.Text.Contains(myLetter))
            {
                lblStatus.Text = "You have already used that letter";
            }
            else
            {
                lblUsedletters.Text += myLetter;
                countTries++;

                bool found = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.Substring(i, 1) == myLetter)
                    {// A match was found
                        arrayHiddenWord[i] = Convert.ToChar(myLetter);
                        found = true;
                    }
                }

                if (found)
                {
                    lblStatus.Text = "Clap clap clap";
                }
                else
                {
                    lblStatus.Text = "Sigh :-(";
                }

                hiddenword = new string(arrayHiddenWord);
                lblHiddenword.Text = hiddenword;
                txtTries.Text = Convert.ToString(countTries);
                txtGuess.Text = "";
                txtGuess.Focus();

                if (!(hiddenword.Contains("*")))
                {
                    tada.Play();
                    lblStatus.Text = "You solved the word.";
                    btnGuess.Enabled = false;
                    btnPlayAgain.Visible = true;
                }
            }
        }

        private void NewGame()
        {
            word = words[RandomNumber.Next(0, words.Length)];
            countTries = 0;

            hiddenword = "";
            for (int i = 0; i < word.Length; i++)
            {
                hiddenword += "*";
            }

            lblHiddenword.Text = hiddenword;

            txtTries.Text = "";
            txtGuess.Text = "";

            lblStatus.Text = "";
            lblUsedletters.Text = "";

            btnGuess.Enabled = true;
            btnPlayAgain.Visible = false;
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            letterEntered();
        }
    }

    class NonLetterException : Exception
    {
        public NonLetterException()
        {

        }

        public NonLetterException(string name) : base(String.Format("The charactor, " + name +
            " is not a what was expected."))
        {

        }
    }
}
