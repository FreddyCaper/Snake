using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,30);
            Console.SetBufferSize(80, 30);
            Console.CursorVisible = false;

            HorizontalLine UpLine = new HorizontalLine(0,79, 0,'#');
            HorizontalLine DownLine = new HorizontalLine(0, 79, 29, '#');
            VerticalLine LeftLine = new VerticalLine(0, 0, 29, '#');
            VerticalLine RightLine = new VerticalLine(79, 0, 29, '#');
            UpLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();
            DownLine.Draw();

          

            Point p2 = new Point(3, 5, '*');
            Snake snake = new Snake(p2, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25,'$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while(true)
            {
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
        }
    }
}
