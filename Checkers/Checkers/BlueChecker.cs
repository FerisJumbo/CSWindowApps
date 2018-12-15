using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class BlueChecker
    {
        private int posx;
        private int posy;

        public BlueChecker(int posx, int posy)
        {
            this.posx = posx;
            this.posy = posy;
        }

        public int getPos(char x_or_y)
        {
            if (x_or_y == 'x')
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
