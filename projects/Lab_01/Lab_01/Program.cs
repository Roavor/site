using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    class Program
    {
        static double funct(double x)
        {
            return Math.Log(x * x + x + 1);
        }
static int findFinishNodeX(double[] arr, double point)
        {
            for (int i = 0; i < arr.Length; i++)
                if (point < arr[i])
                    return i;
            return -1;
        }
        static double countAprValue(double x1, double y1, double x2, double y2, double value)
        {
            return y1 + (y2 - y1) * (value - x1) / (x2 - x1);
        }
        static double firstDerivative(double x)
        {
            return (2 * x + 1) / (x * x + x + 1);
        }
        static double secondDerivative(double x)
        {
            return (2 * (x * x + x + 1) - (2 * x + 1) * (2 * x + 1)) / ((x * x + x + 1) * (x * x + x + 1));
        }
        static void Main(string[] args)
        {
            try
            {
                double[] nodeX = { 0.5, 0.69, 0.78, 0.99, 1.21, 1.34, 1.51, 1.63, 1.71, 1.83 };
                double[] nodeY = { 0.55962, 0.77293, 0.87062, 1.08860, 1.30131, 1.41963, 1.566561, 1.66523, 1.72884, 1.82114 };
                double[] formul = new double[26];
                double[] linApr = new double[26];
                int index = 0;
                double h = 0.06,
                FinishValue = 1.5;
                Console.WriteLine("==========ПЕРВАЯ ЧАСТЬ ЛАБОРАТОРНОЙ===========");
                for (double i = 0; i < FinishValue + h; i += h)
                {
                    formul[index] = funct(i);
                    index++;
                }
                index = 0;
                for (double x = 0; x < FinishValue + h; x += h)
                {
                    if (findFinishNodeX(nodeX, x) == 0)
                    {
                        linApr[index] = countAprValue(nodeX[0], nodeY[0], nodeX[1], nodeY[1], x);
                        index++;
                    }
                    else
                    {
                        linApr[index] = countAprValue(nodeX[findFinishNodeX(nodeX, x) - 1], nodeY[findFinishNodeX(nodeX, x) - 1], nodeX[findFinishNodeX(nodeX, x)], nodeY[findFinishNodeX(nodeX, x)], x);
                        index++;
                    }
                }
                Console.WriteLine("=======================================================");
                double sum = 0, mult = 1;
                index = 0;
                for (double x = 0; x < FinishValue + h; x += h)
                {
                    sum = 0;
                    for (int i = 0; i < nodeY.Length; i++)
                    {
                        mult = nodeY[i];
                        for (int j = 0; j < nodeX.Length; j++)
                        {
                            if (i != j)
                                mult *= (x - nodeX[j]) / (nodeX[i] - nodeX[j]);
                        }
                        sum += mult;
                    }
                    Console.WriteLine("При x = {0:F2} = > y = {2:F6}; y = {3:F6};y = {1:F6}", x, sum, formul[index], linApr[index]);
                    index++;
                }
                Console.WriteLine("=======================================================");
                Console.WriteLine("==========ВТОРАЯ ЧАСТЬ ЛАБОРАТОРНОЙ===========");
                Console.WriteLine("<------Численными методами------>");
                for (int i = 0; i < formul.Length; i++)
                {
                    if (i == 0)
                        Console.WriteLine("x=0,00 => y'={4:F6} {0:F6} {2:F6}; y''={5:F6} {1:F6} {3:F6}", ((formul[1] - formul[0]) / h), (formul[i + 1] - 2 * formul[i]) / (h * h), ((linApr[1] - linApr[0]) / h), (linApr[i + 1] - 2 * linApr[i]) / (h * h), firstDerivative(i * h), secondDerivative(i * h));
                    else if (i == formul.Length - 1)
                        Console.WriteLine("x=1,50 => y'={4:F6} {0:F6} {2:F6}; y''={5:F6} {1:F6} {3:F6}", ((formul[formul.Length - 1] - formul[formul.Length - 2]) / h), (formul[i - 1] - 2 * formul[i]) / (h * h), ((linApr[linApr.Length - 1] - linApr[linApr.Length - 2]) / h), (linApr[i - 1] - 2 * linApr[i]) / (h * h), firstDerivative(1.5), secondDerivative(1.5));
                    else
                        Console.WriteLine("x={4:F2} => y'={5:F6} {0:F6} {2:F6}; y''={6:F6} {1:F6} {3:F6}", ((formul[i + 1] - formul[i - 1]) / (2 * h)), (formul[i + 1] + formul[i - 1] - 2 * formul[i]) / (h * h), ((linApr[i + 1] - linApr[i - 1]) / (2 * h)), (linApr[i + 1] + linApr[i - 1] - 2 * linApr[i]) / (h * h), i * h, firstDerivative(i * h), secondDerivative(i * h));
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }
        }
    }
}
