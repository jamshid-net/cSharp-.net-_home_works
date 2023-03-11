using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_6
{
    internal class Spider : Animal
    {
        public override int legs { get; set; }

        public override void eat()
        {
            Console.WriteLine("spider is eating");
        }

        public override void walk()
        {
            Console.WriteLine("spider is walking");
        }
    }
}
