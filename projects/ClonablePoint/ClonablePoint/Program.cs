using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cloned p3 and stored new Point p4");
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before madification");
            Console.WriteLine("p3={0}",p3);
            Console.WriteLine("p4={0}",p4);
            p4.desc.PetName = "My new Point";
            p4.X = 9;
            Console.WriteLine("\nChanged p4.desc.PetName and p4.X");
            Console.WriteLine("p3 {0}",p3);
            Console.WriteLine("p4 {0}",p4);
            Console.ReadLine();
        }
       
    }
}
