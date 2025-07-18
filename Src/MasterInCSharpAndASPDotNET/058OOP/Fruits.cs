using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058OOP
{
    public class Fruits
    {
        public string _name { get; set; }
        public string _color { get; set; }
        public Fruits() { }

        public Fruits(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Color: {_color}");
        }

    }
}
