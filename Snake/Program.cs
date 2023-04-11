using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            int width = 30;
            int heigth = 20;

            Console.WindowHeight = heigth+5;
            Console.WindowWidth = width+5;

            Wall wall = new Wall(width, heigth, '+');
            wall.Draw();

            Point p = new Point(5, 5, '*');

            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Draw();
            GetEat eat = new GetEat(20, 20, 'Ж');
            Point food = eat.CreateEat(snake.GetSnake());
            Speed speed = new Speed();
            food.Draw();

            while (true)
            {
                Console.SetCursorPosition(0, heigth + 2);
                Console.WriteLine("Player score: " + ((snake.GetLength() * 100) - 500));
                if (snake.Ate(food)) 
                {
                    food = eat.CreateEat(snake.GetSnake());
                    food.Draw();
                } else
                {
                    if (snake.Move(width, heigth)) break;
                }
                Thread.Sleep(speed.SpeedUpdate(snake.GetLength()));
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeControl(key);
                }
            }

            Console.SetCursorPosition(0, heigth + 3);
            Console.ReadKey();
        }

    }
}
