﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeUtilClass.PrintTime();
            TimeUtilClass.PrintData();
            TimeUtilClass o = new TimeUtilClass();
        }
    }
}