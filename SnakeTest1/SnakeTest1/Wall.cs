using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest1
{
    class Wall
    {
        public List<Point> pWall;

        public Wall(int xLeft, int xRight, int yTop, int yDown, char sym)
        {
            pWall = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                for (int y = yTop; y <= yDown; y++)
                {
                    Point p = new Point(x, y, sym);
                    pWall.Add(p);
                }
            }
        }

        public void Draw()
        {
            foreach (Point i in pWall)
            { i.Draw(); }
        }
    }
}
