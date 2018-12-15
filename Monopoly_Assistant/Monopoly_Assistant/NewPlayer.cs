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
    public partial class FrmNewPlayer : Form
    {
        public FrmNewPlayer()
        {
            InitializeComponent();
        }

        public int findOpenSpot()
        {
            for (int x = 0; x < FrmMain.players.Length; x++)
            {
                if (FrmMain.players[x] == null)
                {
                    return x;
                }
            }

            return -1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Player player = new Player(txtName.Text, 1500);
            FrmMain.players[findOpenSpot()] = player;
            this.Close();
        }
    }
}
