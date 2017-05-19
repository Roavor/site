using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
  abstract partial  class Employee
    {
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standart,Gold,Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
        protected string empSSN;
        protected int empAge;
        protected string empName;
        protected int empID;
        protected float currPay;
        protected BenefitPackage empBenefits = new BenefitPackage();
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        public Employee() { }
        public Employee(string name, int id, float pay,string ssn)
            : this(name, 0, id, pay,ssn)
        { }
        
        public Employee(string name,int age, int id,float pay,string ssn)
        {
            //Плохое использование конструктора
            //if (name.Length > 15)
           //  Console.WriteLine("Error! Name must be lesss than 15 characters");
            //else
            //    empName = name;
            Name = name;
            ID = id;
            Age = age;   
            Pay = pay;
            empSSN = ssn;
        }


      /* public string GetName()
        {
            return empName;
        }
        public void SetName(string name)
        {
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be less than 16 characters ");
            else
                empName = name;
        }*/
    }
    abstract partial class Employee
    {
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be lesss than 15 characters");
                else
                    empName = value;
            }
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age {0}:", Age);
            Console.WriteLine("Pay: {0}", Pay);
         }
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
    }


    }
