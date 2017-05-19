using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        static void Main(string[] args)
        {
            Board MyBoard = new Board(10, 10);
            MyBoard.CreateShip(3, 5, 4, 1);
            MyBoard.CreateShip(4, 5, 2, 1);
            MyBoard.CreateShip(8, 5, 1, 1);
            Console.Read();
        }
    }
}
