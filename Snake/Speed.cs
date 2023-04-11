using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Speed
    {
        int speed = 200;
        public Speed() 
        {
            
        }

        public int SpeedUpdate(int snakeLength)
        {
            if (200 - snakeLength * 5 > 0) return 200 - snakeLength * 5;
            else return 10;
        }
    }
}
