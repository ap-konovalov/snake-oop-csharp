using System;
using System.Collections.Generic;

namespace Snake
{
    // У насть есть класс Figure он называется базовый, в нем мы описываем общие действия для всех
    // фигур HorizontalLine и  VerticalLine мы решили отенсти к фигурам, это делается так class HorizontalLine : Figure
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
