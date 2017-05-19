using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static public void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("Drawing IDraw3D compitible type");
            itf3d.Draw3D();
        }
        static public Ipointy  FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is Ipointy)
                {
                    return s as Ipointy;
                }
            }
            return null;

        }
        static void Main(string[] args)
        {
            /*First Example
            Hexagon hex = new Hexagon();
             Console.WriteLine("Points: {0}", hex.Points);
             Circle c = new Circle("Lisa");
             Ipointy itfPt = null;
             try
             {

             }
             catch (InvalidCastException e)
             {

                 Console.WriteLine(e.Message); ;
             }
             //  Чи може інтерпретуватись як IPointy
             Hexagon hex2 = new Hexagon("Peter");
             Ipointy itfPt2 = hex2 as Ipointy;
             if (itfPt2!=null)
             {
                 Console.WriteLine("Points; {0}",itfPt2.Points);
             }
             else
             {
                 Console.WriteLine("OOOPS! Not pointy...");
             }*/
            //Second example
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("Jojo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                if (myShapes[i] is Ipointy)
                {
                    Console.WriteLine("-> Points: {0}",((Ipointy) myShapes[i]).Points);
                }
                else
                {
                    Console.WriteLine("-> {0}\'s not pointy! ",myShapes[i].PetName);
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < myShapes.Length; i++)
            {
                if (myShapes is IDraw3D)
                {
                    DrawIn3D((IDraw3D)myShapes[i]);
                }
            }
            Ipointy FirstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points",FirstPointyItem.Points);
                Console.ReadLine();
        }
    }
}
