using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Ship : Pole
    {
        public List<Pole> ShipPoles = new List<Pole>();


        private int Direction;
        public int SizeOfShip { get; private set; }
        
        public Ship(int x, int y, int size, int direction) : base(x, y)
        {
            SizeOfShip = size;
            Direction = (int)direction;
            AddPole();
        }

        public void AddPole()
        {
            if (Direction == 1)
            {
                for (int i = 0; i < SizeOfShip; i++)
                {
                    ShipPoles.Add(new Pole(directionX, directionY - i));
                }
            }
            else if (Direction == 2)
            {
                for (int i = 0; i < SizeOfShip; i++)
                {
                    ShipPoles.Add(new Pole(directionX + i, directionY));
                }
            }
        }

    }
}
