using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_1
{
    class Program
    {
        static void strum(double n, double d, double u, double a)
        
        { int i = 0;
            double b;
            do
            {
                i++;
                
                b =  1 / (a + d * (i-1));
                double I  = u *b;
                Console.WriteLine(I);
            }
            while (i != n);
        }
        static double Input(string S)
        {
            Console.WriteLine(S);
            double n = 0;
            try
            {
                n = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("error");
            }
            return n;
        }
         
        static void Main()
        {
            
            double n = Input("Input number of resistors");
           
            double u =Input("Input voltage");
           
            double d = Input("Input difference between voltages");
           
            double a = Input("Input first opir");
            strum(n, d, u, a);
            
            
        }

    }
}
