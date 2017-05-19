using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        private bool carIsDead;
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName{ get; set; }
        
        public Car() { }
        public Car(string name,int maxSp,int currSp)
        {
            CurrentSpeed = currSp;
            PetName = name;
            MaxSpeed = maxSp;
        }
        public delegate void CarEngineHandler(string msqForCaller);
        private CarEngineHandler listOfHandles;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandles = methodToCall;
        }
        public void Accelerate(int delta)
        {
            if(carIsDead)
            {
                if(listOfHandles!=null)
                {
                    Console.WriteLine("Sorry,this car is dead...");
                }
                
            }
            else
            {
                CurrentSpeed += delta;
                if (10==(MaxSpeed-CurrentSpeed)&&(listOfHandles!=null))
                {
                    listOfHandles("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed>=MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                    Console.WriteLine("CurrentSpeed = {0}",CurrentSpeed);
            }
        }
    }
}
