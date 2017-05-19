using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
   class PointRef
{
    public int X;
    public int Y;
    public PointRef(int XPos, int YPos)
    {
        this.X = XPos;
        this.Y = YPos;
    }
    public void Increment()
    {
        X++;
        Y++;
    }
    public void Decrement()
    {
        X--;
        Y--;
    }
    public void Display()
    {
        Console.WriteLine("X={0} Y={1}", X, Y);
    }
    public static void ValueTypeAssigment2()
    {
        PointRef p1 = new PointRef(10, 10);
        PointRef p2 = p1;
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
            PointRef.ValueTypeAssigment2();
            Console.ReadKey();

        }
    }
}
 