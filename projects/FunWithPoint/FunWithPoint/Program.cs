using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithPoint
{
    class Point
    {
        public int X;
        public int Y;
        public Point(int XPos, int YPos)
        {
            this.X = XPos;
            this.Y = YPos;
        }
        
        public void Display()
        {
            Console.WriteLine("X={0} Y={1}", X, Y);
        }
        public static void ValueTypeAssigment2()
        {
            Point p1 = new Point(10, 10);
            Point p2 = p1;
            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("\n Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point.ValueTypeAssigment2();
            Console.ReadKey();

        }
    }
}
