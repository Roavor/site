﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Employee emp2 = new Employee();
            Employee joy = new Employee();
            joy.Age++;
            Console.ReadLine();
        }
    }
}
