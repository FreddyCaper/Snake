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

            HorizontalLine UpLine = new HorizontalLine(0,79, 0,'#');
            HorizontalLine DownLine = new HorizontalLine(0, 79, 29, '#');
            VerticalLine LeftLine = new VerticalLine(0, 0, 29, '#');
            VerticalLine RightLine = new VerticalLine(79, 0, 29, '#');
            UpLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();
            DownLine.Draw();

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(3, 5, '@');
            Snake snake = new Snake(p2, 4, Direction.RIGHT);
            snake.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
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
