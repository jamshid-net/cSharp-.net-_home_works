using OOP_6.Task_5.Classes;
using OOP_6.Task_5.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_5
{
    internal class Foo : Bar , Interface1
    {

        public string job { get; set; }
        public int MyProperty { get; set; }

        public void jump()
        {
            Console.WriteLine("jumped!");
        }

        public void run()
        {
            Console.WriteLine("run!");
        }
    }
}
