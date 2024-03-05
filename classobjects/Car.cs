using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classobjects
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _colour;
        public Car(string name, int hp, string colour)
        {
            _name = name;
            _hp = hp;
            _colour = colour;
            Console.WriteLine($"{_name} Created");
        }
        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");

        }
        public void Details() 
        {
            Console.WriteLine($"{_name} has {_hp} horsepower and is {_colour}");
        }
        public void Stop()
        {
            Console.WriteLine($"{_name} was stopped");
        }
    }
}
