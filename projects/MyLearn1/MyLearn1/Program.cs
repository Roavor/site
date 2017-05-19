using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearn1
{
    class Program
    {
        static void GetUserData()
        {
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello {0}! You are {1} years old",name,age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dear daughter");
            GetUserData();
            Console.ReadKey();
        }
    }
}
