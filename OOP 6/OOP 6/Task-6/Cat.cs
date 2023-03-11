using OOP_6.Task_6.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_6
{
    class Cat : Animal, IPet
    {
        public string name { get; set; }
        public override int legs { get; set; }

        public override void eat()
        {
            Console.WriteLine("cat is eating!");
        }

      

        public void Play()
        {
            Console.WriteLine("cat is playing");
        }

       

        public override void walk()
        {
            Console.WriteLine("cat is walking");
            
        }
    }
}
