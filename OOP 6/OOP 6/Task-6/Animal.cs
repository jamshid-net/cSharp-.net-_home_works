using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_6
{
     abstract class Animal
    {
        abstract public int legs { get; set; }
        public Animal()
        {

        }
        public Animal(int legs)
        {
            this.legs = legs;
        }
        public abstract void eat();
        public abstract void walk();
       

    }
}
