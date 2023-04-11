using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figure
    {
        protected List<Point> pLine;

        public virtual void Draw()
        {
            foreach (Point p in pLine)
            {
                p.Draw();
            }
        }
    }
}
