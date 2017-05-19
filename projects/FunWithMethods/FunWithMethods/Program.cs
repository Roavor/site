using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordOut
{
    class Program
    {
        static void Add(int x,int y,out int ans)
        {
            ans = x + y;
        }
        static void Main(string[] args)
        {
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
