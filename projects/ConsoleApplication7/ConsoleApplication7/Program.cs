using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Point
    {
        private string S;
        public byte x;
        public byte y;
        public Point()
        {
            this.S="Colour";
        }
        public Point(byte x, byte y)
        {
            this.x = x;
            this.y = y;
        }
        public static byte InputB(string S)
        {
            byte a = 0;
            Console.WriteLine(S);
            try
            {
                a = byte.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "False data");
            }
            return a;
        }
        public string Colour
        {
            set
            {
                
                if (value == "Green" || value == "Blue" || value == "Red")
                {
                   S=value;
                }
                else
                {
                    S="Colour is not true";
                }
            }
            get
            {
                return S;
            }
        }
        public override string ToString()
        {
            return "Your point:colour=" +S+";x="+x+";y="+y;
        }
        public string CorrectColour()
        {
            string ans;
            do
            {

                Console.WriteLine("Do you want change colour?Yes/No");
                ans = Console.ReadLine();
                if (ans == "Yes")
                {
                    Console.WriteLine("Input correct colour");
                    this.S = Console.ReadLine();
                }
            }
            while (ans == "Yes");
            return S;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                byte x = Point.InputB("input x");
                byte y = Point.InputB("input y");
                Console.WriteLine("Input colour of your point,Red/Blue/Green");
                Point Point1 = new Point(x, y);
            Point Point2 = new Point();
            string S = Console.ReadLine();
                Point1.Colour = S;
            Point1.CorrectColour();
            Point1.ToString();
            Console.WriteLine(Point1);
                Console.ReadKey();
            }
        }
    }

