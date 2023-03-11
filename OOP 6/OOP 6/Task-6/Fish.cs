using OOP_6.Task_6.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_6
{
    internal class Fish : Animal, IPet
    {
        public override int legs { get; set; }
        public string name { get; set; }

        public override void eat()
        {
            Console.WriteLine("fish is eating");
        }

        public void Play()
        {
            Console.WriteLine("fish is playing");
        }

        public override void walk()
        {
            Console.WriteLine("fish is walking");
        }
    }
}
