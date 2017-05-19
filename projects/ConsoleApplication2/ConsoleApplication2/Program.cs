using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_noo
{
    class Program
    {
        static void Xyz(ref int x,ref  int y,ref  int z)
        {
            int c;
            if (x == y || z == y || z == y)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (y > x)

                {
                    c = x;
                    x = y;
                    y = c;
                }
                if (z > x)
                {
                    c = x;
                    z = x;
                    z = c;
                }
                if (z > y)

                {
                    c = y;
                    z = y;
                    z = c;

                }

            }
            
        }
        static int Input(string S)
        {
            int a = 0;
            Console.WriteLine(S);
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "False data");
            }
            return a;
        }
       static void Main()
        {
            int x = Input("Input x");
            int y = Input("Input y");
            int z = Input("Input z");
         Xyz(ref x,ref y,ref z);
            Console.WriteLine("x={0:f0}", x);
            Console.WriteLine("y ={ 0:f0}",y);
            Console.WriteLine("z ={ 0:f0}", z);
        }
    }
}
