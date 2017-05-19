using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateArray
{
    class Program
    {
        static void ArrayIniilizations()
        {
            //Три способа создания и иниациализации массива
            string[] stringArray = new string[]
                { "one","two",};
            bool[] boolArray = { false, false, true };
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            //Неявно типизировинные локальные массивы
            var a = new[] { 1, 10, 100 };
            //
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Rofm & Void";
            foreach(object obj in myObjects)
            {
                Console.WriteLine("Type: {0},Value {1}",obj.GetType(),obj);
            }
        }
        static void Main(string[] args)
        {
            ArrayIniilizations();
            Console.ReadKey();
        }
    }
}
