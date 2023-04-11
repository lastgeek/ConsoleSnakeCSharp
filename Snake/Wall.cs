using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Wall : Figure
    {

        Line upLine;
        Line downLine;
        Line leftLine;
        Line rightLine;
        public Wall(int width, int heigth, char sym) 
        {
            upLine = new Line(0, 0, width, Direction.Right, sym);
            downLine = new Line(0, heigth, width, Direction.Right, sym);
            leftLine = new Line(0, 0, heigth, Direction.Down, sym);
            rightLine = new Line(width, 0, heigth+1, Direction.Down, sym);
        }
        
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
