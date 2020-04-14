using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {

        List<Point> pList;
        

        public VerticalLine(int xPoz, int startY, int endY, char sym)
        {
            pList = new List<Point>();


            for (int y = startY; y <= endY; y++)
            {
                pList.Add(new Point(xPoz, y, sym));
            }

        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
