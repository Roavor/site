﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        public struct Point<T>
        {
            private T xPos;
            private T yPos;
            public Point (T xVal,T yVal)
            {   
                xPos = xVal;
                yPos=yVal;
            }
                public T X
            {
                get { return xPos; }
                set { xPos = value; }
            }
            public T Y
            {
                get { return yPos; }
                set { yPos = value; }
            }
            public override string ToString()
            {
                return string.Format("{0}, {1}", xPos, yPos);
            }
            public void ResetPoint()
            {
                xPos = default(T);
                yPos = default(T);
            }
        }
        static void Main(string[] args)
        {
            Point<int> p = new Point<int>(10, 10);
            Point<string> t = new Point<string>("Point 1", "Point2");
            t.ResetPoint();
            Console.WriteLine(t.ToString());
            Console.ReadLine();
        }
    }
}
