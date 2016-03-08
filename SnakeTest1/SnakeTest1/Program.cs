using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '*');
 //           p1.Draw();
            Point p2 = new Point(3, 4, '#');
 //           p2.Draw();


            Wall W = new Wall(2, 4, 3, 5, '#');
            W.Draw();

            Console.ReadLine();
        }
    }
}
