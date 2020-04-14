using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y,char sym)
        {
            pList = new List<Point>();

            for(int i= xLeft; i<=xRight; i++)
            {
                pList.Add(new Point(i, y, sym));
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
