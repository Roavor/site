using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;

namespace LateBuildingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = null;
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if(a!=null)

        }
        static void CreateUsingLateBuilding(Assembly asm)
        {
            try
            {
                Type MiniVan = asm.GetType("CarLibrary.MiniVan");
                object obj = Activator.CreateInstance(MiniVan);
                Console.WriteLine("Creared a {0} using late building",obj);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
