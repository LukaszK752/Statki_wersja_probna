using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Board
    {
        public int Width { get; private set; }
        public int Heigth { get; private set; }

        public List<Pole> PolesList = new List<Pole>();
        public List<Ship> ShipList = new List<Ship>();

        public Board (int W, int H)
        {
            Width = W;
            Heigth = H;
            CreatePoles();
        }

        public void CreatePoles()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                {
                    PolesList.Add(new Pole(i, j));
                }
            }
        }

        public bool CreateShip(int X, int Y, int Size, int direction)
        {
            if (CheckPolesAvailability(X, Y, Size, direction))
            {
                ReservePoles(X, Y, Size, direction);
                ShipList.Add(new Ship(X, Y, Size, direction));
                return true;
            }
            else
                return false;
        }

        public bool CheckPolesAvailability(int X, int Y, int Size, int direction)
        {
            if (direction == 1 && X + Size < Width)
            {
                for (int i = X; i < X + Size; i++)
                {
                    if (!CheckSingePoleAvailability(i, Y))
                        return false;
                }
                return true;
            }
            else if (direction == 0 && Y + Size < Heigth)
            {
                for (int i = X; i < X + Size; i++)
                {
                    if (!CheckSingePoleAvailability(i, Y))
                        return false;
                }
                return false;
            }
            else
                return true;
        }

        public bool CheckSingePoleAvailability(int x, int y)
        {
            if (PolesList.Where(p =>
               (p.directionX == x)
               && (p.directionY == y)
               && (p.isChecked == true)).ToList().Count() > 0)
                return false;
            else
                return true;
        }

        public void ReservePoles(int X, int Y, int Size, int direction)
        {
            if (direction == 1)
            {
                for (int i = X; i < X + Size; i++)
                {
                    PolesList.Find(p =>
                    p.directionX.Equals(i)
                    && p.directionY.Equals(Y))
                    .checkPole();
                }
            }
            else if (direction == 0)
            {
                for (int i = Y; i < Y + Size; i++)
                {
                    PolesList.Find(p =>
                    p.directionX.Equals(X)
                    && p.directionY.Equals(i))
                    .checkPole();
                }
            }
        }
    }
}
