using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuptOfDatasShortandBiger
{
    class Program
    {
        static void NarrowindAttemps()
        {
            byte myByte = 0;
            int myInt = 200;
            //Явно привести int  k short (и разрешить потерю данних).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}",myByte);
        }
        static int Add(int n,int m )
        {
            return n + m;
        }
        static void Main(string[] args)
        {
            short numb1 = 30000, numb2 = 30000;
            //Явно привести int k byte (без потери данных).
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0}+{1}={2}",numb2,numb1,answer);
            NarrowindAttemps();
            Console.ReadKey();
        }
    }
}
