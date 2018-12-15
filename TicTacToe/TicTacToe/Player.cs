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
    public struct Player
    {
        private bool won;
        private string name;

        public Player(string Name)
        {
            won = false;
            name = Name;
        }

        public void setWon(bool Won)
        {
            won = Won;
        }

        public bool getWon()
        {
            return won;
        }

        public string getName()
        {
            return name;
        }
    }
}
