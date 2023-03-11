using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5_Dars.Vazifa_3
{
    class Duck
    {
        public void quack()
        {
            Console.WriteLine("quack quack");
        }

        public void swim()
        {
            Console.WriteLine("duck is swimmed!");
        }
        public virtual void display()
        {
            Console.WriteLine("Duck like methods");
        }
    }

    class MallarDuck:Duck
    {
        public override void display()
        {
            Console.WriteLine("looks like a mallard");
        }
    }
    class RedheadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("looks like a redhead");
        }
    }
}
