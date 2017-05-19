using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Poslidovnist(double N)
        {
           
            double i=1;
            do
            {
               double a = Input("Input next element");
                if (a > N) 
                {
                    
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
                N = a;
            }
            while (i <= N);
                
        }
        
        static double Input(string S)
        {
            Console.WriteLine(S);
            double n = 0;
            try
            {
                n = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "error");
            }
            return n;
        }
        
        static void Main(string[] args)
        {
            double N = Input("Input N");
            Poslidovnist(N);
           
        }
    }
}
