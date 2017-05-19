using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFunctoinalityData
{
    class Program
    {
        static void CharFunctoinality()
        {
            Console.WriteLine("=>CharTypeFunctionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'):{0}",char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}",char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpase('Hello There', 5): {0}",char.IsWhiteSpace("Hello There",5));
            Console.WriteLine("char.IsWhiteSpase('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}",char.IsPunctuation('?'));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            CharFunctoinality();
        }
    }
}
