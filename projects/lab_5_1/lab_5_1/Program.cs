using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_1
{
    class Program
    {
        static int InputInt(string S)
        {
            int a = 0;
                Console.WriteLine(S);
                try
                {
                    a = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "False data");
                }
            return a;
        }
        static  int [] InputArr(int n)
        {
            int[] Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = InputInt("Input next element");
                Arr[i] = a;
            }
            return Arr;
        }

        static int min(int[] Arr)
        {

            int n = Arr.GetLength(0);
            int k = 0;
            int b = Arr[k];
            for (; k < n; k++)
            {
                if (Arr[k] < b)
                {
                    b = Arr[k];
                }
            }
            return b;
        }
        static void NewArr(int b, int[] Arr)
        {
            int n = Arr.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                if (Arr[i] > 0)
                {
                    Arr[i] = b;
                }
            }
            
        }
            
        
        static void PrintArr(int []Arr)
        {
            int rows = Arr.GetLength(0);
            for (int i=0;i< rows;i++)
            {
                Console.Write(Arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int n =InputInt("Input n");
            int[] Arr = InputArr(n);
            int b = min(Arr);
            NewArr(b, Arr);
            PrintArr(Arr);
        }
    }
}
