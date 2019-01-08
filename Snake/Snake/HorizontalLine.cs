using System;
using System.Collections.Generic;

namespace Snake
{
    // У насть есть класс Figure в которым мы описываем общие действия для всех
    // фигур HorizontalLine мы решили отенсти к фигурам, это делается так class HorizontalLine : Figure.
    // HorizontalLine теперь стал наследником класса Figure, унаследовав все его свойства

    class HorizontalLine : Figure
    {

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
 
        }

    }
}
