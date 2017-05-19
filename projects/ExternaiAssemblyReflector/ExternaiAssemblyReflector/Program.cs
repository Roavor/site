using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ExternaiAssemblyReflector
{
    class Program
    {
        static void DisplayTypesIaAsm(Assembly asm )
        {
            Console.WriteLine("->",asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type  t in types)
            {
                Console.WriteLine("Types ;{}",t);
            }
        }
        static void Main(string[] args)
        {
            string asmName = "";
            Assembly asm = null;
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate or enter q to quite:");
                asmName = Console.ReadLine();
                if (asmName.ToUpper() == "q")
                {
                    break;
                }
                try
                {
                    asm = Assembly.Load(asmName);
                    DisplayTypesIaAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry.Can't fined assembly...");
                }
            } while (true);
    }
}
