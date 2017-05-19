using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();
            Point anotherPoint = new Point (20,20);
            anotherPoint.DisplayStats();
            Point finalPoint = new Point { X = 30, Y = 30 };
            Point pt = new Point(10, 16) { X = 100, Y = 100 };
            pt.DisplayStats();
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            Console.ReadLine();

        }
    }
}
