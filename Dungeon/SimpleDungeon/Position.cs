using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDungeon
{
    internal class Position 
    {
        public int XCoordinate {  get; private set; }
        public int YCoordinate { get; private set; }


        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
        public void MoveUp()
        {
            YCoordinate += 1;
        }

        public void MoveDown()
        {
            YCoordinate -= 1;
        }

        public void MoveLeft()
        {
            XCoordinate -= 1;
        }

        public void MoveRight()
        {
            XCoordinate += 1;
        }



    }
}
