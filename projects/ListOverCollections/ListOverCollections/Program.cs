using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOverCollections
{
    class Program
    {
        public void GetFastCars(List<Car> myCars)
        {
            var fastCars = from c in myCars where c.Speed > 55 select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is not going too fast",car.PetName);
            }
        }
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car {PetName="Henry",Color ="Lilver",Speed=100,Make="BMV" },
                new Car {PetName="Henry",Color ="Lilver",Speed=100,Make="BMV" },
                new Car {PetName="Henry",Color ="Lilver",Speed=100,Make="BMV" },
                new Car {PetName="Henry",Color ="Lilver",Speed=100,Make="BMV" }
            };
        }
    }
}
