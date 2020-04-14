using System;

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

            HorizontalLine Hline = new HorizontalLine(10,50, 7,'=');
            Hline.Draw();

            VerticalLine Vline = new VerticalLine(20, 1, 20, '|');
            Vline.Draw();






            Console.ReadLine();
        }
       

    }
    
}
