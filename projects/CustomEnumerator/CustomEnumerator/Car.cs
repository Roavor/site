using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Car
    {
        private bool carIsDead;
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
                Console.WriteLine("{0} is out of order...",PetName);
            }
            else
            {
                CurrSped += delta;
                if (CurrSped>MaxSpeed)
                {    
                    CurrSped = 0;
                    carIsDead = true;
                    Exception ex = new Exception(string.Format("{0} has overhead", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";
                    ex.Data.Add("TimeStamp", string.Format("The car has exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "Youhave a lead food.");
                    throw ex;
                }
                else
                {
                    Console.WriteLine("=>CurrentSpeed = {0}",CurrSped);
                }
            }
        }
    }
}
