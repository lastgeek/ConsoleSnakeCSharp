using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
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

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public bool OutTheBox(int width, int heigth)
        {
            return x > 0 && x < width && y > 0 && y < heigth;
        }

        public void Move(int offset, Direction direction)
        {
            switch(direction)
            {
                case Direction.Right:
                    x += offset;
                    break;
                case Direction.Left:
                    x -= offset;
                    break;
                case Direction.Up:
                    y -= offset;
                    break;
                case Direction.Down:
                    y += offset;
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clean()
        {
            sym = ' ';
            Draw();
        }
    }
}
