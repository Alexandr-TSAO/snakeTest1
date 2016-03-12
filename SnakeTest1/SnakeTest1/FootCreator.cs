using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest1
{
    class FootCreator
    {
        int mapHeight;
        int mapWidth;
        char sym;

        Random random = new Random();

        public FootCreator(int mapHeight, int mapWidth, char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        public Point Foot(Snake S)
        {
            int x;
            int y;
            do{
            x = random.Next(2, mapHeight - 2);
            y = random.Next(2, mapWidth - 3);
            } while(S.Coincides(x, y));
            
            return new Point(x, y, sym);
        }
    }
}
