using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Rusty", 90);
            try
            {
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadExeption e)
            {

                Console.WriteLine(e.Message) ;
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.CrankTunes(true);
            }
            Console.ReadLine(); 
        }
    }
}
