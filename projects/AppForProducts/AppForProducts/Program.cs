using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProducts
{
    abstract class Employeer
    {
        protected double salary;
        public double Salarye { get { return salary; } set { salary = value; } }
        public int Age { get; set; }
        public string Name { get; set; }
        public Employeer() { }
        public Employeer(int yourAge, string yourName)
        {
            Age = yourAge;
            Name = yourName;
        }
        public override string ToString()
        {
            return string.Format("Age : {0};Name : {1};", Age, Name);
        }
    }
    class HourlyEmployee : Employeer
    {
       
        public int time;
        public HourlyEmployee(int yourAge, string yourName, int time, int money) : base(yourAge, yourName)
        {
            Salarye = money;
            this.time = time;
        }
        public override string ToString() => base.ToString() + string.Format("Salary for {1} hours : {0}", time * salaryPerHour, time);

    }
    class SalariedEmployee : Employeer
    {
        
        public SalariedEmployee(int yourAge, string yourName, int salarys) : base(yourAge, yourName)
        {
            Salarye = salarys;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Salary : {0}", salary);
        }
    }
    class Manager : Employeer
    {
        public Manager() { }
        public Manager(int yourAge, string yourName, int salarys) : base(yourAge, yourName)
        {
            salary = salarys;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Salary : {0}", salary);
        }
    }
    static class Company
    {

        public static double BonusToSalary(Employeer a, double money) => a.Salarye + money;

      
    }     
    class Program
    {
        static void Main(string[] args)
        {
            List < Employeer > Bands= new List<Employeer>();
            Manager a = new Manager();
            Bands.Add(a);
        }
    }
}
