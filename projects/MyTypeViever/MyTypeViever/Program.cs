using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyTypeViever
{
    class Program
    {
        static void ListMethods(Type t)
        {
            MethodInfo[] mi = t.GetMethods();
           // var MethodNames = from n in t.GetMethods() select n.Name;
            foreach (MethodInfo i in mi)
            {
                string retVal = i.ReturnType.FullName;
                string paramInfor = "(";
                foreach (ParameterInfo pi in i.GetParameters())
                {
                    paramInfor += string.Format("{0} {1}", pi.ParameterType, pi.Name);
                }
                paramInfor += ")";
                Console.WriteLine("-> {0} {1} {2}",retVal,i.Name,paramInfor);
            }
            Console.WriteLine();
        }
        static void ListFields(Type t)
        {
            var fieldsNames = from n in t.GetFields() select n.Name;
            foreach (var i in fieldsNames)
            {
                Console.WriteLine("-> {0}",i);
                Console.WriteLine();
            }

        }
        static void ListInterfaces(Type t)
        {
            var ifaces = from n in t.GetInterfaces() select n;
            foreach (Type i in ifaces)
            {
                Console.WriteLine("-> {0}",i);
                Console.WriteLine();
            }
        }
        static void ListVariousStats(Type t)
        {
            Console.WriteLine("Base class is : {0}",t.BaseType);
            Console.WriteLine("Is type abstract? {0}",t.IsAbstract);
            Console.WriteLine("Is type sealed? {0}",t.IsSealed);
            Console.WriteLine("Is type generic? {0}",t.IsGenericTypeDefinition);
            Console.WriteLine("Is type a class type? {0}",t.IsClass);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate or enter q to quite:");
                typeName = Console.ReadLine();
                if (typeName.ToUpper() == "q")
                {
                    break;
                }
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    ListVariousStats(t);
                    ListFields(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch
                {
                    Console.WriteLine("Sorry.Can't fined type...");
                }

            } while (true);
        }
    }
}
