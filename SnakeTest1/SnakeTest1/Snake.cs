using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest1
{
    class Snake : Figure
    {
        public Directional directional;

        public Snake(Point tail, int lenght, Directional _directional)
        {
            directional = _directional;
            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, directional);
                pList.Add(p);
            }

        }


        internal void Mowe()
        {
            Console.SetCursorPosition(0, 24);
            Console.Write(pList.Count);
            if (pList.Count == 1)
            {
                Console.SetCursorPosition(0, 24);
                Console.Write("end");
                Console.ReadKey();
            }
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = NextPoint();
            

            tail.Clean();
            if (head.x < 79 & head.x > 0 & head.y < 23 & head.y > 0)
            {
                pList.Add(head);
                head.Draw();
            }
        }

        public Point NextPoint()
        {
            Point head = pList.Last();
            Point NewHead = new Point(head);
            NewHead.Move(1, directional);
            return NewHead;
        }

        public void ContronSnake(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    this.directional = Directional.LEFT;
                    break;

                case ConsoleKey.RightArrow:
                    this.directional = Directional.RIGHT;
                    break;

                case ConsoleKey.UpArrow:
                    this.directional = Directional.TOP;
                    break;

                case ConsoleKey.DownArrow:
                    this.directional = Directional.DOWN;
                    break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = pList.Last();
            if (head.Coincides(food))
            {
                Point newHead = NextPoint();
                pList.Add(newHead);
                newHead.Draw();
                return true;
            }
            else return false;
        }

        public bool Coincides(int x, int y)
        {
            bool res = false;
            foreach (Point i in pList)
            {
                if ((i.x == x) && (i.y == y))
                    res = true;
                
            }

            return res;
        }
    }
}
