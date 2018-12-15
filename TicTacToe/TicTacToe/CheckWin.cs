using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class CheckWin : FrmMain
    {
        public static void checkForWin()
        {
            if (win1[0].BackgroundImage == PicX)
            {
                if (win1[1].BackgroundImage == PicX)
                {
                    if (win1[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }

            if (win2[0].BackgroundImage == PicX)
            {
                if (win2[1].BackgroundImage == PicX)
                {
                    if (win2[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }

            if (win3[0].BackgroundImage == PicX)
            {
                if (win3[1].BackgroundImage == PicX)
                {
                    if (win3[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }

            if (win4[0].BackgroundImage == PicX)
            {
                if (win4[1].BackgroundImage == PicX)
                {
                    if (win4[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }

            if (win5[0].BackgroundImage == PicX)
            {
                if (win5[1].BackgroundImage == PicX)
                {
                    if (win5[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }

            if (win6[0].BackgroundImage == PicX)
            {
                if (win6[1].BackgroundImage == PicX)
                {
                    if (win6[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }

            if (win7[0].BackgroundImage == PicX)
            {
                if (win7[1].BackgroundImage == PicX)
                {
                    if (win7[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }

            if (win8[0].BackgroundImage == PicX)
            {
                if (win8[1].BackgroundImage == PicX)
                {
                    if (win8[2].BackgroundImage == PicX)
                    {
                        playerX.setWon(true);
                    }
                }
            }



            if (win1[0].BackgroundImage == PicO)
            {
                if (win1[1].BackgroundImage == PicO)
                {
                    if (win1[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }

            if (win2[0].BackgroundImage == PicO)
            {
                if (win2[1].BackgroundImage == PicO)
                {
                    if (win2[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }

            if (win3[0].BackgroundImage == PicO)
            {
                if (win3[1].BackgroundImage == PicO)
                {
                    if (win3[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }

            if (win4[0].BackgroundImage == PicO)
            {
                if (win4[1].BackgroundImage == PicO)
                {
                    if (win4[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }

            if (win5[0].BackgroundImage == PicO)
            {
                if (win5[1].BackgroundImage == PicO)
                {
                    if (win5[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }

            if (win6[0].BackgroundImage == PicO)
            {
                if (win6[1].BackgroundImage == PicO)
                {
                    if (win6[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }

            if (win7[0].BackgroundImage == PicO)
            {
                if (win7[1].BackgroundImage == PicO)
                {
                    if (win7[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }

            if (win8[0].BackgroundImage == PicO)
            {
                if (win8[1].BackgroundImage == PicO)
                {
                    if (win8[2].BackgroundImage == PicO)
                    {
                        playerO.setWon(true);
                    }
                }
            }
        }
    }
}
