using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
  partial  class Employee
    {
        private string empSSN;
        private int empAge;


        private string empName;
        private int empID;
        private float currPay;
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
    partial class Employee
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
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age {0}:", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
        public void GiveBonus(float amount)
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
