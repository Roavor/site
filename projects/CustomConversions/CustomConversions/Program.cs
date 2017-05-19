using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        public struct Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public Rectangle(int w, int h) : this()
            {
                Width = w;
                Height = h;

            }
            public void Draw()
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            public override string ToString()
            {
                return string.Format("[Width = {0}; Height = {1}]", Width, Height);
            }
            public static implicit operator Rectangle(Square s)
            {
                Rectangle r = new Rectangle();
                r.Height = s.Lenght;
                r.Width = s.Lenght * 2;
                return r;
            }
        }
        public struct Square
        {
            public int Lenght { get; set; }
            public Square(int l) : this()
            {
                Lenght = l;
            }
            public void Draw()
            {
                for (int i = 0; i < Lenght; i++)
                {
                    for (int j = 0; j < Lenght; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public override string ToString()
            {
                return string.Format("[Lenght = {0}]", Lenght);
            }
            public static explicit operator Square(Rectangle r)
            {
                Square s = new Square();
                s.Lenght = r.Height;
                return s;
            }
        }

        static void Main(string[] args)
            {
            }
       
    
}
