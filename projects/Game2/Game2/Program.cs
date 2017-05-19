using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Program
    {
        public static int RemoveNoise(int n,int d)
        {
            string f = d.ToString();
            char[] arr1 = f.ToCharArray();
            int b=0;
            int a=1;
            string s="Start: ";
            for (int i=0;i<=n;i++)
            {
                a = i * i;
                Console.Write(a+",");
                s =s + a.ToString();
            }
            char[] arr = s.ToCharArray();
            Console.WriteLine(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==arr1[0])
                {
                    b++;
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input d:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(RemoveNoise(n,d));
            Console.ReadKey();
        }
    }
}
