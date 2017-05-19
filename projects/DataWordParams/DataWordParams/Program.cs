using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWordParams
{
    class Program
    {
        static double CalculateAverage(params double[] values)
        {
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
        static void Main(string[] args)
        {
            //3 способа вызова метода CalculateAverage
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}",average);
            //double[] data = { 4.0, 3.2, 5.7 };
            //average =CalculateAverage(data);
            //Console.WriteLine("Average of data is: {0}",average);
            //
            //Console.WriteLine("Average of data is: {0}",CalculateAverage());
            Console.ReadKey();

        }
    }
}
