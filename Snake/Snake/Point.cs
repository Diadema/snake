using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
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

        public Point (Point p)// задавать точку с помощью другой точки))
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move( int offset, Direction direction)// сдвигать эту точку на рссстояние offset по направлению direction
        {
            if (direction == Direction.RIGHT)// координату икс увеличиваем на размер смещения
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x-offset;
            }
            else if (direction == Direction.UP)
            {
                y = y + offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }


        public void Drow()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(sym);
    }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
