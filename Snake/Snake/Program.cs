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

            Snake snake = new Snake(p1,4,Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }

    }
}
