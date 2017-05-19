using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeVaiTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;
        public Person(string name,int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }
        public void Display()
        {
            Console.WriteLine("Name: {0},Age {1}",personName,personAge);
        }
       public static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            p.personName = "Bob";
            p = new Person("Nikki", 89);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();
            Person.SendAPersonByValue(fred);
            Console.WriteLine("\n After by value call,Person is:");
            fred.Display();
            Console.ReadKey();
        }
    }
}
