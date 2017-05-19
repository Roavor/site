using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Colour = "Red";
            Console.WriteLine("Your car is named {0}?",c.PetName);
            c.DisplayStays();
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of cars in garage: {0}",g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}",g.MyAuto.PetName);
            Console.ReadLine();
        }
    }
}
