﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
                Console.WriteLine("Member name {0}",e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message {0}",e.Message);
                Console.WriteLine("Sourse {0}",e.Source);
                Console.WriteLine("Stack  {0}",e.StackTrace);
                Console.WriteLine("Help Link: {0}",e.HelpLink);
                if (e.Data!=null)
                {
                    foreach(DictionaryEntry de in e.Data)
                        Console.WriteLine("-> {0}: {1}",de.Key,de.Value);
                }
            }
            

            Console.ReadLine();
        }
    }
}
