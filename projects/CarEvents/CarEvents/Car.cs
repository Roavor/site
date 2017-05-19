using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Car
    {
        private bool carIsDead;
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            PetName = name;
            MaxSpeed = maxSp;
        }
        public delegate void CarEngineHandler(string msq);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded!=null)
                {
                    Exploded("Sorry,This car is dead...");
                }
                else
                {
                    CurrentSpeed += delta;
                    if(10==MaxSpeed-CurrentSpeed&&AboutToBlow!=null)
                    {
                        AboutToBlow("Careful body!Gonna blow!");
                    }
                    if (CurrentSpeed >= MaxSpeed)
                        carIsDead = true;
                    else
                        Console.WriteLine("Current speed = {0}",CurrentSpeed);
                }
            }
        }
    }
}
