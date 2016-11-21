using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);// создание точной копии хвостовой части
                p.Move(i, direction);// эта точка сдвигается к позиции по направлении direction
                pList.Add(p);// добавить эту точку в список
            }
        }
    }
}
