using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hex = new Hexagon("Betch");
            hex.Draw();
            Circle cir = new Circle("Cindy");
            cir.Draw();
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Betch"), new Hexagon("Linda") };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();
        }
    }
}
