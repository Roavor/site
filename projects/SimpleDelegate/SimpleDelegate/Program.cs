using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int x, int y);
    public class SimpleMath
    {
        public  int Add(int x, int y)
        {return x+y;}
        public  int Subtract(int x,int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate  d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method name : {0}",d.Method);
                Console.WriteLine("Type name : {0}",d.Target);
            }
        }
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();

            BinaryOp b = new BinaryOp(m.Add);
            Console.WriteLine("10+10 is {0}",b(10,10));
            DisplayDelegateInfo(b);
            Console.ReadLine();
        }
    }
}
