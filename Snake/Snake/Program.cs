using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');


            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Snake snake = new Snake(p1,4,Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }


        }

    }
}
