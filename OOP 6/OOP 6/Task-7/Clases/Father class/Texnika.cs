using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_7.Clases.Father_class
{
     abstract class Texnika
    {
        public virtual void Start()
        {
            Console.WriteLine($"{GetType().Name} is started");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"{GetType().Name} is stopped");
        }
        public bool onRepier { get; set; }
    }
}
