using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            
            Point p2 = new Point(4,3,'#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(3,7,4,'$');
            line.Drow();

            VerticalLine vline = new VerticalLine(10, 2, 10, '#');
            vline.Drow();

            Console.ReadLine();
        }

    }
}
