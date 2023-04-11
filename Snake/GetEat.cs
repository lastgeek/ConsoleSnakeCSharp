using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class GetEat
    {
        int width;
        int height;
        char sym;

        Random rand = new Random();
        public GetEat(int width, int height, char sym)
        {
            this.width = width;
            this.height = height;
            this.sym = sym;
        }

        public Point CreateEat(List<Point> points)
        {
            bool hit = false;
            int count = 0;
            Point food;
            do
            {
                hit = false;
                int x = rand.Next(2, width - 2 + count);
                int y = rand.Next(2, height - 2 + count);
                food = new Point(x, y, sym);
                foreach (Point p in points)
                {
                    if (p.IsHit(food))
                    {
                        hit = true;
                        count++;
                    }
                }
            } while(hit);
            return food;
        }
    }
}
