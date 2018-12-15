using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public class Map : FrmMain
    {
        private int MAXX;
        private int MAXY;

        public Map()
        {
            this.MAXX = 4;
            this.MAXY = 8;
        }

        public PictureBox getPic(int x, int y)
        {
            if (x == 1 && y == 1)
            {
                return usedBoxes[0];
            }
            else if (x == 1 && y == 2)
            {
                return usedBoxes[9];
            }
            else if (x == 1 && y == 3)
            {
                return usedBoxes[16];
            }
            else if (x == 1 && y == 4)
            {
                return usedBoxes[24];
            }
            else if (x == 2 && y == 1)
            {
                return usedBoxes[1];
            }
            else if (x == 2 && y == 2)
            {
                return usedBoxes[5];
            }

            return null;
        }
    }
}
