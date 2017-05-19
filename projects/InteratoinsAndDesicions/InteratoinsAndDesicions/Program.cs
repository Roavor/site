using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteratoinsAndDesicions
{
    class Program
    {
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMV", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
        }
    }
}
