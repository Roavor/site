using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemArrayReserveAndClear
{
    class Program
    {
        static void SystenArrayFunctionality()
        {
            Console.WriteLine("Working with System.Array");
          
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sister of Mercy" };
         
            Console.WriteLine("Here is hte array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.WriteLine(gothicBands[i]+",");
            }
            Console.WriteLine("\n");
          
            Array.Reverse(gothicBands);
            Console.WriteLine("The reserved array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.WriteLine(gothicBands[i]+",");
            }
            Console.WriteLine("\n");
      
            Console.WriteLine("Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.WriteLine(gothicBands[i]+",");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            SystenArrayFunctionality();
            Console.ReadKey();
        }
    }
}
