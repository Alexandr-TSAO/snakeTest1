using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest1
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Directional directional)
        {
            switch (directional)
            {
                case Directional.LEFT:
                    x = x - offset;
                    break;
                case Directional.RIGHT:
                    x = x + offset;
                    break;
                case Directional.TOP:
                    y = y - offset;
                    break;
                case Directional.DOWN:
                    y = y + offset;
                    break;

            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            Console.SetCursorPosition(0, 24);
           
        }

        public override string ToString()
        {
            return  x.ToString() + "," + y.ToString() + "," + sym.ToString();
        }

        public void Clean()
        {
            sym = ' ';
            this.Draw();
        }

        public bool Coincides(Point p)
        {
            if ((this.x == p.x) && (this.y == p.y))
                return true;
            else return false;
        }
    }
}
