using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_1
{
    class Program
    {
        static void strum(int n, double d, double u, double a)

        {
            int i = 0;
            double r = 1;
            do
            {
                r = 1 / r + 1 / a + d * n;
                double I = u / r;
                i++;
                Console.WriteLine(I);

            }
            while (i == n);
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Input number of resistors");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Input voltage");
                double u = double.Parse(Console.ReadLine());
                Console.WriteLine("Input difference between voltage");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Input the first voltage");
                double a = double.Parse(Console.ReadLine());
                strum(n, d, u, a);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

    }
}
