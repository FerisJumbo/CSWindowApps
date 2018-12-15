using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Assistant
{
    public partial class FrmMain : Form
    {
        public static RadioButton[] MoneyRadios = new RadioButton[7];
        public static int[] MoneyAmounts = new int[7];
        public static Player[] players = new Player[8];
        public static string lookFor;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MoneyRadios[0] = rad1;
            MoneyRadios[1] = rad5;
            MoneyRadios[2] = rad10;
            MoneyRadios[3] = rad20;
            MoneyRadios[4] = rad50;
            MoneyRadios[5] = rad100;
            MoneyRadios[6] = rad500;
            
            MoneyAmounts[0] = 1;
            MoneyAmounts[1] = 5;
            MoneyAmounts[2] = 10;
            MoneyAmounts[3] = 20;
            MoneyAmounts[4] = 50;
            MoneyAmounts[5] = 100;
            MoneyAmounts[6] = 500;

            numericA.Enabled = false;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewPlayer np = new FrmNewPlayer();
            np.ShowDialog();
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            lboxPlayers.Items.Clear();

            foreach(Player player in players)
            {
                if (player != null)
                {
                    lboxPlayers.Items.Add(player.getName() + " -- " + player.getMoney());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkUseMoney.Checked == false)
            {
                RadioButton selectedRadio = null;
                int selectedMoney = 0;

                for (int i = 0; i < 7; i++)
                {
                    if (MoneyRadios[i].Checked)
                    {
                        selectedRadio = MoneyRadios[i];
                        selectedMoney = MoneyAmounts[i];
                    }
                }

                if (selectedRadio != null)
                {// Will look at txtMoney
                    if (lboxPlayers.SelectedItem != null)
                    {
                        lookFor = lboxPlayers.SelectedItem.ToString();

                        foreach (Player player in players)
                        {
                            if (player != null)
                            {
                                if ((player.getName() + " -- " + player.getMoney()) == lookFor)
                                {
                                    player.addMoney(selectedMoney);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("no person selected", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("There was an Error in Processing you request", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (lboxPlayers.SelectedItem != null)
                {
                    lookFor = lboxPlayers.SelectedItem.ToString();

                    foreach (Player player in players)
                    {
                        if (player != null)
                        {
                            if ((player.getName() + " -- " + player.getMoney()) == lookFor)
                            {
                                player.addMoney(Convert.ToInt32(numericA.Value));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("no person selected", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            btnUpdate_Click(this, e);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (chkUseMoney.Checked == false)
            {
                RadioButton selectedRadio = null;
                int selectedMoney = 0;

                for (int i = 0; i < 7; i++)
                {
                    if (MoneyRadios[i].Checked)
                    {
                        selectedRadio = MoneyRadios[i];
                        selectedMoney = MoneyAmounts[i];
                    }
                }

                if (selectedRadio != null)
                {// Will look at txtMoney
                    if (lboxPlayers.SelectedItem != null)
                    {
                        lookFor = lboxPlayers.SelectedItem.ToString();

                        foreach (Player player in players)
                        {
                            if (player != null)
                            {
                                if ((player.getName() + " -- " + player.getMoney()) == lookFor)
                                {
                                    player.subMoney(selectedMoney);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("no person selected", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("There was an Error in Processing you request", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (lboxPlayers.SelectedItem != null)
                {
                    lookFor = lboxPlayers.SelectedItem.ToString();

                    foreach (Player player in players)
                    {
                        if (player != null)
                        {
                            if ((player.getName() + " -- " + player.getMoney()) == lookFor)
                            {
                                player.subMoney(Convert.ToInt32(numericA.Value));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("no person selected", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            btnUpdate_Click(this, e);
        }

        private void chkUseMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseMoney.Checked)
            {
                groupBox1.Enabled = false;
                numericA.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = true;
                numericA.Enabled = false;
            }
        }
    }
}
