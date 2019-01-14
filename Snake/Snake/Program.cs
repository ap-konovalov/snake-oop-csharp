using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail() )
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }






            //while (true)
            //{
            //    if(Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.HandleKey(key.Key);
            //    }
            //    Thread.Sleep(100);
            //    snake.Move();
            //}


        }

    }
}
