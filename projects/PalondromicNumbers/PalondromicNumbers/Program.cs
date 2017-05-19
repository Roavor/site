using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalondromicNumbers
{
    class Program
    {
        static bool IsPaliandromic(int x)
        {
            string a =x.ToString();
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            string b = new string(arr);
            Console.WriteLine(b);
            return a==b? true:false;
        }
        static int MinPalindromic(out int d)
        {
            int a = 999;
            int i;
            d = 1;
            for ( i = 999; i >0; i--)
            {
                if (IsPaliandromic(a*i))
                {
                    d = a * i;
                    return i;
                }
            }
            return i;
        }
        static int MaxPalindromic(int a,out int d)
        {

            int i=999;
            d = 0;
            for ( i = 999; i >=a; i--)
            {
                  if (IsPaliandromic(i * j&&()))
                    {
                        d = a * i;
                        return i * a;
                    }
            }
            return i;
        }
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
