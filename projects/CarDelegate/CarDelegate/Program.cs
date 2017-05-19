using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        public static void OnCarEngineEvent(string msq)
        {
            Console.WriteLine("\n***********Message from Car object*********");
            Console.WriteLine("=> {0}",msq);
            Console.WriteLine("*********************************************");
        }
        static void Main(string[] args)
        {
            Car c1 = new Car("Slug Bag", 100, 10);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Console.WriteLine("Speeding up");
            for(int i=0;i<6;i++)
            {
                c1.Accelerate(20);
                Console.ReadLine();
            }
        }
    }
}
