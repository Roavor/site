using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExeption
{
    class Car
    {
        private bool carIsDead =false;
        public const int MaxSpeed = 100;
        public int CurrSped { get; set; }
        public string PetName { get; set; }
        private Radio theMusicBox = new Radio();
        public Car() { }
        public Car (string name,int speed)
        {
            CurrSped = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrSped += delta;
                if (CurrSped > MaxSpeed)
                {
                    CurrSped = 0;
                    carIsDead = true;
                    CarIsDeadExeption ex = new CarIsDeadExeption(string.Format("{0} has overheated!", PetName), "You have a lead flood", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    throw ex;
                }
                else
                {
                    Console.WriteLine("=>CurrentSpeed = {0}", CurrSped);
                }
            }

        }
    }
}
