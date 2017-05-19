using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_2
{
    class Program
    {
        static double InputD(string S)
        {
            double a = 0;
            Console.WriteLine(S);
            try
            {
                a = double.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "False data");
            }
            return a;
        }
        static double[,] InputArr(string S)
        {
            Console.WriteLine(S);
            double[,] Arr = new double[5, 10];
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    double a = InputD("Input next element");
                    Arr[j, i] = a;
                }
            }
            return Arr;
        }      
        static double [] Max(double [,] Arr)
        {
            int n = 0;
            double b = Arr[1,1];
            double[] Arr1 = new double[5];
            for (int j=0;j<5;j++)
            {
                for (int i = 1; i < 10; i++)
                { 
                    if (b < Arr[j, i])
                    {
                        b = Arr[j, i];
                    }
                }
                Arr1[n] = b;
                n++;
            }
            return Arr1;
        }
        static double Min(double [] Arr)
        {
            double b = Arr[0];
            for (int n=0;n<5;n++)
            {
                if (b < Arr[n])
                    {
                    b = Arr[n];
                    }
            }
            return b;
        }
        static void PrintMatrix(double[,] Arr)
        {
            int rows = Arr.GetLength(0);
            for (int j=0;j<5;j++)
            {
                
                for (int i = 0; i < rows; i++)
                {
                    Console.Write(Arr[i,j]+"\t ");
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            double[,] Arr = InputArr("Create array");
            double[] Arr1 = Max(Arr);
            double b = Min(Arr1);
            PrintMatrix(Arr);
            Console.WriteLine(b);
            Console.ReadKey();


        }

    }
}

