using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Rivnist()
        {
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
                        if (x == y; y = z; z = x);
                        {
                            bool ansver = true;
                            Console.WriteLine(ansver);
                            else 
                            ansver = false;
                            Console.WriteLine(ansver);
                        }                        
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
           

            static void Main(string[] args)
        {
           try
            {
               
               
            }
            catch
            {
                Console.WriteLine("error");
            }
           Console.ReadKey();
       }
    }
}
