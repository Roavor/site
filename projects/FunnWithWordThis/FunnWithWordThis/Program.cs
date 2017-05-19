using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnWithWordThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWhely();
            Console.WriteLine("Rider name is {0}",c.driverName);
            Console.ReadLine();
        }
    }
}
