using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
       
        public int currSpeed;
        public string petName;
        public void PrintState()
        {
            Console.WriteLine("{0} isgoing {1} MPH.",petName,currSpeed);

        }
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
