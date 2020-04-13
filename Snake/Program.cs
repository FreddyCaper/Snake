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

            Point p2 = new Point(3,5,'#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(10);
            numList.Add(11);
            numList.Add(12);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            /* Далее здесь домашнее задание */

            /* Список хранящий символы */

            List<char> chList = new List<char>();
            chList.Add('*');
            chList.Add('$');
            chList.Add('#');


            /* Список с точками. Создать 4 точки с разными координатами и добавить их в свой список */
            List <Point> mpL = new List<Point>();
            mpL.Add(new Point(3, 3, '$'));
            mpL.Add(new Point(4, 3, '$'));
            mpL.Add(new Point(5, 3, '$'));
            mpL.Add(new Point(5, 2, '$'));
            mpL.Add(new Point(5, 4, '$'));


            /* Выведем наш список точек методом Draw */
            foreach(Point tp in mpL)
            {
                tp.Draw();
            }
        
        }
       

    }
    
}
