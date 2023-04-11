using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction) 
        {
            direction = _direction;
            pLine = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pLine.Add(p);
            }   
        }

        public int GetLength()
        {
            return pLine.Count;
        }

        public List<Point> GetSnake()
        {
            return pLine;
        }

        public bool Move(int width, int heigth)
        {
            Point tail = pLine.First();
            Point head = GetNextPoint();
            foreach (Point p in pLine)
            {
                if (head.IsHit(p) || !head.OutTheBox(width, heigth)) return true;
            }
            pLine.Remove(tail);
            pLine.Add(head);
            tail.Clean();
            head.Draw();
            return false;
        }

        public Point GetNextPoint()
        {
            Point head = pLine.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void SnakeControl(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    if (direction != Direction.Left) direction = Direction.Right;
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.Right) direction = Direction.Left;
                    break;
                case ConsoleKey.UpArrow:
                    if (direction != Direction.Down) direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.Up) direction = Direction.Down;
                    break;
            }
        }

        public bool Ate(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food)) 
            {
                head.Draw();
                food.sym = head.sym;
                pLine.Add(food);
                return true;
            }
            else 
                return false;
        }
    }
}
