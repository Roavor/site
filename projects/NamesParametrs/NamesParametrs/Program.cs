using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesParametrs
{
    class Program
    {
        static void DisplayFancyMessage(ConsoleColor textColor,ConsoleColor backgroungColor,string message)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
        static void Main(string[] args)
        {
            DisplayFancyMessage(message: "Wow! Very fancy indeed",
            textColor: ConsoleColor.Red,
            backgroungColor: ConsoleColor.White);
            DisplayFancyMessage(backgroungColor: ConsoleColor.Green,
                message: "Testeng...",
                textColor: ConsoleColor.DarkBlue);
            Console.ReadKey();
        }
    }
}
