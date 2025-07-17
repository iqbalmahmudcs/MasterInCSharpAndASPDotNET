using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058OOP
{
    public class Person
    {
        public string _name;
        public  int _age;
        public Person() { }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }


    }
}
