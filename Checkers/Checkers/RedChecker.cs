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
    public class RedChecker
    {
        private int posx;
        private int posy;

        public RedChecker(int posx, int posy)
        {
            this.posx = posx;
            this.posy = posy;
        }



        public int getPos(char x_or_y)
        {
            if(x_or_y == 'x')
            {
                return this.posx;
            }
            else
            {
                return this.posy;
            }
        }
    }
}
