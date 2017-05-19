using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {


        static void xyz(int x, int y, int z)
        {
            if (x > y||y>z)
                               {
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                    Console.WriteLine(z);
                }
            if (y > x||x>z)
              
                {
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                    Console.WriteLine(z);
                }
            if (z > x||x>y)
              
                {
                    Console.WriteLine(z);
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }
            if (y > z||z>x)
                
                {
                    Console.WriteLine(y);
                    Console.WriteLine(z);
                    Console.WriteLine(x);
                }

            if (z > y||y>z)
              
                {
                    Console.WriteLine(z);
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
            if (x > z||z>y)
               
                {
                    Console.WriteLine(x);
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }
            if (x == y || z == y || z == x)
                Console.WriteLine("error");           ;
        }


        static void Main()
        {
            string ans = " ";
            do
            {
                try
                {
                    Console.WriteLine("input x");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("input y");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("input z");
                    int z = int.Parse(Console.ReadLine());
                    {
                        Console.WriteLine("Error");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("do you want again? Yes/No");
                    ans = Console.ReadLine();
                }
            }
            while (ans == "yes");
        }



    }

}
