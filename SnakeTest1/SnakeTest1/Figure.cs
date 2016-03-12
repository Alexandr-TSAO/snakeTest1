using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest1
{
    class Figure
    {
        public List<Point> pList;

        public void Draw()
        {
            foreach (Point i in pList)
            { i.Draw(); }
        }
    }
}
