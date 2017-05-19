using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02_2
{
    class Program
    {
        static bool check (double a, double b, double c )
        {
            return ((a==b)||(a==c)||(b==c));
        }
        static double Input(string S)
        {
          
            Console.WriteLine(S);
            double a = 0;
            try
            {
              a = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("error");

            }
            return a;
        }
        static void Main(string[] args)
        {
            double a = Input("Vvedit first element");
            double b = Input("Vvedit second element");
            double c = Input("Vvedit third element");
            Console.WriteLine(check(a, b, c));
            Console.ReadKey();
        }
    }
}
