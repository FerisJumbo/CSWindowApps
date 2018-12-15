using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class FrmMain : Form
    {
        // Creating the BitMap for the checker peices
        public static System.Drawing.Bitmap RED = Properties.Resources.CheckerRed;
        public static System.Drawing.Bitmap BLUE = Properties.Resources.CheckerBlue;

        // Creating the Map
        public static Map map = new Map();

        // All nonmoveable boxes are stored here
        public static PictureBox[] unusedBoxes = new PictureBox[32];
        // All moveable boxes are stored here
        public static PictureBox[] usedBoxes = new PictureBox[32];

        //All RedCheckers are stored here
        public static RedChecker[] Reds = new RedChecker[12];

        // Creating all the Red Checker Peices
        private static RedChecker Red1 = new RedChecker(1, 1);
        private static RedChecker Red2 = new RedChecker(2, 1);
        private static RedChecker Red3 = new RedChecker(3, 1);
        private static RedChecker Red4 = new RedChecker(4, 1);
        private static RedChecker Red5 = new RedChecker(1, 2);
        private static RedChecker Red6 = new RedChecker(2, 2);
        private static RedChecker Red7 = new RedChecker(3, 2);
        private static RedChecker Red8 = new RedChecker(4, 2);
        private static RedChecker Red9 = new RedChecker(1, 3);
        private static RedChecker Red10 = new RedChecker(2, 3);
        private static RedChecker Red11 = new RedChecker(3, 3);
        private static RedChecker Red12 = new RedChecker(4, 3);

        // Creating all the Blue Checker Peices
        private static BlueChecker Blue1 = new BlueChecker(1, 1);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Assigning all unused boxes
            {
                unusedBoxes[0] = unused1;
                unusedBoxes[1] = unused2;
                unusedBoxes[2] = unused3;
                unusedBoxes[3] = unused4;
                unusedBoxes[4] = unused5;
                unusedBoxes[5] = unused6;
                unusedBoxes[6] = unused7;
                unusedBoxes[7] = unused8;
                unusedBoxes[8] = unused9;
                unusedBoxes[9] = unused10;
                unusedBoxes[10] = unused11;
                unusedBoxes[11] = unused12;
                unusedBoxes[12] = unused13;
                unusedBoxes[13] = unused14;
                unusedBoxes[14] = unused15;
                unusedBoxes[15] = unused16;
                unusedBoxes[16] = unused17;
                unusedBoxes[17] = unused18;
                unusedBoxes[18] = unused19;
                unusedBoxes[19] = unused20;
                unusedBoxes[20] = unused21;
                unusedBoxes[21] = unused22;
                unusedBoxes[22] = unused23;
                unusedBoxes[23] = unused24;
                unusedBoxes[24] = unused25;
                unusedBoxes[25] = unused26;
                unusedBoxes[26] = unused27;
                unusedBoxes[27] = unused28;
                unusedBoxes[28] = unused29;
                unusedBoxes[29] = unused30;
                unusedBoxes[30] = unused31;
                unusedBoxes[31] = unused32;
            }

            // Assigning all used boxes
            {
                usedBoxes[0] = pbox1;
                usedBoxes[1] = pbox2;
                usedBoxes[2] = pbox3;
                usedBoxes[3] = pbox4;
                usedBoxes[4] = pbox5;
                usedBoxes[5] = pbox6;
                usedBoxes[6] = pbox7;
                usedBoxes[7] = pbox8;
                usedBoxes[8] = pbox9;
                usedBoxes[9] = pbox10;
                usedBoxes[10] = pbox11;
                usedBoxes[11] = pbox12;
                usedBoxes[12] = pbox13;
                usedBoxes[13] = pbox14;
                usedBoxes[14] = pbox15;
                usedBoxes[15] = pbox16;
                usedBoxes[16] = pbox17;
                usedBoxes[17] = pbox18;
                usedBoxes[18] = pbox19;
                usedBoxes[19] = pbox20;
                usedBoxes[20] = pbox21;
                usedBoxes[21] = pbox22;
                usedBoxes[22] = pbox23;
                usedBoxes[23] = pbox24;
                usedBoxes[24] = pbox25;
                usedBoxes[25] = pbox26;
                usedBoxes[26] = pbox27;
                usedBoxes[27] = pbox28;
                usedBoxes[28] = pbox29;
                usedBoxes[29] = pbox30;
                usedBoxes[30] = pbox31;
                usedBoxes[31] = pbox32;
            }

            // Assigning all Red Checkers
            {
                Reds[0] = Red1;
                Reds[1] = Red2;
                Reds[2] = Red3;
                Reds[3] = Red4;
                Reds[4] = Red5;
                Reds[5] = Red6;
                Reds[6] = Red7;
                Reds[7] = Red8;
                Reds[8] = Red9;
                Reds[9] = Red10;
                Reds[10] = Red11;
                Reds[11] = Red12;
            }


            NewGame();
        }

        public void NewGame()
        {
            foreach (RedChecker Checker in Reds)
            {
                int posx = Checker.getPos('x');
                int posy = Checker.getPos('y');

                PictureBox pic = map.getPic(posx, posy);
                pic.BackgroundImage = RED;
            }
        }



        public System.Drawing.Bitmap getColor(string RED_or_Blue)
        {
            if (RED_or_Blue == "RED")
            {
                return RED;
            }
            else
            {
                return BLUE;
            }
        }
    }
}
