using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTheButton
{
    public partial class FrmMain : Form
    {
        Random randomPositionx = new Random();
        Random randomPositiony = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnClick.TabStop = false;
        }

        private void btnClick_MouseEnter(object sender, EventArgs e)
        {
            int randomx = randomPositionx.Next(0, 601 - (70 * 2));
            int randomy = randomPositiony.Next(0, 401 - (60));
            btnClick.Location = new Point(randomx, randomy);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void btnHa_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
