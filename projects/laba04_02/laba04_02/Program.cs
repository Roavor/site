using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba04_02
{
    class Program
    {
        static int Input(string S)
        {
            int a = 0;
            Console.WriteLine(S);
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "False data");
            }
            return a;
        }
        static void Progress(int n)
        {
            int b = Input("First element");
            int a = Input("second element");
            int i = 2;
            while (i < n && a < b)
            {
                i++;
                b = a;
                Console.WriteLine("0");
                a = Input("next");
            }
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            int n = Input("Input numbers of items");
            Progress(n);
        }
    }
}
