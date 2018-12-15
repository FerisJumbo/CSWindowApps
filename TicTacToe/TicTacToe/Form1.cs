using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FrmMain : Form
    {
        //All posible winning moves
        public static PictureBox[] win1 = new PictureBox[3]; // top row
        public static PictureBox[] win2 = new PictureBox[3]; // middle row
        public static PictureBox[] win3 = new PictureBox[3]; // bottom row
        public static PictureBox[] win4 = new PictureBox[3]; // left column
        public static PictureBox[] win5 = new PictureBox[3]; // middle column
        public static PictureBox[] win6 = new PictureBox[3]; // right column
        public static PictureBox[] win7 = new PictureBox[3]; // back slash line
        public static PictureBox[] win8 = new PictureBox[3]; // forward slash line

        // Creating new Player objects
        public static Player playerX = new Player("X");
        public static Player playerO = new Player("O");

        // Sets images equall to a variable
        public static Bitmap PicX = Properties.Resources.X;
        public static Bitmap PicO = Properties.Resources.O;

        // Current Player is assigned here
        private char currentPlayer;

        // Counts how many spaces are full
        private int spacesFull;

        // Initializes Pictures array
        private PictureBox[] Pictures = new PictureBox[9];

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add wining moves to a certain group
            {
                win1[0] = pbox7; win1[1] = pbox8; win1[2] = pbox9;

                win2[0] = pbox4;
                win2[1] = pbox5;
                win2[2] = pbox6;

                win3[0] = pbox1;
                win3[1] = pbox2;
                win3[2] = pbox3;

                win4[0] = pbox7;
                win4[1] = pbox4;
                win4[2] = pbox1;

                win5[0] = pbox8;
                win5[1] = pbox5;
                win5[2] = pbox2;

                win6[0] = pbox9;
                win6[1] = pbox6;
                win6[2] = pbox3;

                win7[0] = pbox7;
                win7[1] = pbox5;
                win7[2] = pbox3;

                win8[0] = pbox9;
                win8[1] = pbox5;
                win8[2] = pbox1;
            }

            // Adds Pictures to a main group
            {
                Pictures[0] = pbox1;
                Pictures[1] = pbox2;
                Pictures[2] = pbox3;
                Pictures[3] = pbox4;
                Pictures[4] = pbox5;
                Pictures[5] = pbox6;
                Pictures[6] = pbox7;
                Pictures[7] = pbox8;
                Pictures[8] = pbox9;
            }

            NewGame();
        }

        private void NewGame()
        {
            spacesFull = 0;
            playerX.setWon(false);
            playerO.setWon(false);
            currentPlayer = 'x';
            lblStatus.Text = "Player X, please select a box.";
            foreach (PictureBox pictures in Pictures)
            {
                pictures.BackgroundImage = null;
                pictures.Enabled = true;
            }
            btnRestart.Visible = false;
        }

        private void BoxSelection(PictureBox selectedPicture)
        {
            if (currentPlayer == 'x')
            {// Runs if player is X
                currentPlayer = 'o';
                lblStatus.Text = "Player O, please select a box.";
                selectedPicture.BackgroundImage = PicX;
                selectedPicture.Enabled = false;
                spacesFull++;
            }
            else
            {// Runs if player is O
                currentPlayer = 'x';
                lblStatus.Text = "Player X, please select a box.";
                selectedPicture.BackgroundImage = PicO;
                selectedPicture.Enabled = false;
                spacesFull++;
            }

            CheckWin.checkForWin();

            if (playerX.getWon()  == true)
            {
                Won(playerX);
            }
            else if (playerO.getWon() == true)
            {
                Won(playerO);
            }
            else if (spacesFull == 9)
            {
                btnRestart.Visible = true;
                lblStatus.Text = "All spaces full.  Its a tie.";
            }
        }

        private void Won(Player player)
        {
            foreach(PictureBox picture in Pictures)
            {
                picture.Enabled = false;
            }

            btnRestart.Visible = true;
            lblStatus.Text = "Player " + player.getName() + ", has won the game!";
        }

        private void pbox1_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox1);
        }

        private void pbox2_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox2);
        }

        private void pbox3_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox3);
        }

        private void pbox4_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox4);
        }

        private void pbox5_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox5);
        }

        private void pbox6_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox6);
        }

        private void pbox7_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox7);
        }

        private void pbox8_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox8);
        }

        private void pbox9_Click(object sender, EventArgs e)
        {
            BoxSelection(pbox9);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
