using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Line : Figure
    {
        public Line(int x, int y, int length, Direction direction, char sym) 
        {
            pLine = new List<Point>();

            switch(direction)
            {
                case Direction.Right:
                    for (int i = x; i < length; i++)
                    {
                        pLine.Add(new Point(i, y, sym));
                    }
                    break;
                case Direction.Left:
                    for (int i = x; i < length; i--)
                    {
                        if (i > 0) pLine.Add(new Point(i, y, sym));
                    }
                    break;
                case Direction.Up:
                    for (int i = y; i < length; i--)
                    {
                        if (i > 0) pLine.Add(new Point(x, i, sym));
                    }
                    break;
                case Direction.Down:
                    for (int i = y; i < length; i++)
                    {
                        pLine.Add(new Point(x, i, sym));
                    }
                    break;
            }
        }
    }
}
