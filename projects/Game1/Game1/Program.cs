using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Program
    {
        public static int  TripleDouble(long num1, long num2)
        {
            char a;
            int b=0;
            char[] mass = num1.ToString().ToCharArray();
            char[] mass1 = num2.ToString().ToCharArray();
            for (int i = 0; i < (mass.Length - 2); i++)
            {
                if ((mass[i] == mass[i + 1]) && (mass[i] == mass[i + 2]))
                {
                    a = mass[i];
                    for (int j = 0; j < (mass1.Length - 1); j++)
                    {
                        if ((mass1[j] == mass1[j + 1]) && (mass1[j] == a))
                        {
                            b = 1;
                        }
                    }
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            Console.WriteLine("Your answer is:{0}", TripleDouble(a, b));
            Console.ReadLine();
        }
    }
}

