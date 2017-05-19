using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsOfString
{
    class Program
    {
        static void NewInf()
        {
            string myLongString = @"It is a very 
                very 
                     very 
                            long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Hello world""");
        }
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColour\tSpeed\tPet\t Name\a";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone Loves \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a");
            Console.WriteLine("All finished.\n\n\n\a");
        }
        static void Main(string[] args)
        {
            EscapeChars();
            NewInf();
            Console.ReadKey();
        }
    }
}
