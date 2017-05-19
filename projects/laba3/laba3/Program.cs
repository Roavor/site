using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        static void masa()
        {
             string ans = " ";
            do
            {
                try
                {
                    Console.WriteLine("input x");
                    int a = int.Parse(Console.ReadLine());
        Console.WriteLine("input y");
                    int b = int.Parse(Console.ReadLine());
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
}
