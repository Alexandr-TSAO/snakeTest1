using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize( 80, 25);

            Wall W1 = new Wall(0, 0, 0, 24, '#');
            Wall W2 = new Wall(79, 79, 0, 24, '#');
            Wall W3 = new Wall(0, 79, 24, 24, '#');
            Wall W4 = new Wall(0, 79, 0, 0, '#');

            W1.Draw();
            W2.Draw();
            W3.Draw();
            W4.Draw();

            Console.CursorVisible = false;
            Point p1 = new Point(15, 12, '*');
            Snake S = new Snake(p1, 20, Directional.RIGHT);
            S.Draw();

            FootCreator FoodCreate = new FootCreator(80, 25, '$');
            Point foot = FoodCreate.Foot(S);
            foot.Draw();
                       
            while(true)
            {
                if (S.Eat(foot))
                {
                    foot = FoodCreate.Foot(S);
                    foot.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    while (Console.KeyAvailable) key = Console.ReadKey();
                    S.ContronSnake(key.Key);
                }
                
                S.Mowe();
                
                Thread.Sleep(100);
            }
           

            Console.ReadLine();
        }
    }
}
