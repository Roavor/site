using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*В пустой прямоугольной комнате размерами A х B х C (длина, ширина, высота) на пол упала уснувшая муха.
Паук, находившийся на одной из стен, или на полу комнаты, начал двигаться к ней по кратчайшему пути.

На какое расстояние он при этом переместится?

Входные данные

В первой строке задано размеры комнаты A, B, C. Во второй строке - координаты мухи на полу X1, Y1, и паука X2, Y2, Z2.

Все входные данные - целые числа, не превышающие 500.

Выходные данные

Единственное число - расстояние, на которое переместится паук, вычисленное с точностью до 2-х знаков после запятой.*/
namespace E_OlympExercise_1_
{
   
    
    class Program
    {
        static double Input()
        {

            
            double a = 0;
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("error");

            }
            return a;
        }
        static double Distance(double x, double x1,double y,double y1,double z)
        {
            return Math.Sqrt(Math.Pow((x + x1), 2) + Math.Pow((y + y1), 2) + Math.Pow((z + 0), 2));
        }
        static void Main(string[] args)
        {
            double x = Input(); double x1 = Input(); double y = Input(); double y1 = Input(); double z = Input();
            Console.WriteLine(Distance(x,x1,y,y1,z));
        }
    }
}
