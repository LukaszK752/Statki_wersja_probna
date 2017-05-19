using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Pole
    {
        public int directionX { get; private set; }
        public int directionY { get; private set; }
        public bool isChecked { get; private set; }

        public Pole(int x, int y)
        {
            directionX = x;
            directionY = y;
            isChecked = false;
        }

        public void checkPole ()
        {
            isChecked = true;
        }
    }
}
