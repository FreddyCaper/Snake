using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        { }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    y = y - offset;
                    break;

                case Direction.DOWN:
                    y = y + offset;
                    break;

                case Direction.LEFT:
                    x = x - offset;
                    break;

                case Direction.RIGHT:
                    x = x + offset;
                    break;

            }

        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
