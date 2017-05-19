using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnWithWordThis
{
    class Motorcycle
    {
        public int DriverIntencity;
        public string driverName;
        public Motorcycle() { Console.WriteLine("In derault ctor"); }
        public Motorcycle(int intencity)
            : this(intencity, "")
        { Console.WriteLine("In ctor taking an int"); }
        public Motorcycle(string name)
            : this(0, name)
        { Console.WriteLine("In ctor taking string"); }
        public Motorcycle(int intensity,string name)
        {
            Console.WriteLine("In master ctor");
            if (intensity>10)
            {
                intensity = 10;
            }
            DriverIntencity = intensity;
            driverName = name;
        }
        public void SetDriverName(string name)
        {
            driverName = name;
            this.driverName = name;
        }
        public void PopAWhely()
        {
            for(int i=0;i<=DriverIntencity;i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaaaawww!");
            }
        }
    }
}
