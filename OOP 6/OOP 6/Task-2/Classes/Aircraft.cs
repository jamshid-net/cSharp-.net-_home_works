using OOP_6.Task_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_2.Classes
{
    class Aircraft :IPlane , IEngine
    {
        public int hpEngine => throw new NotImplementedException();

        public int countEngine => throw new NotImplementedException();

        public string modelEngine => throw new NotImplementedException();

        public virtual void start()
        {
            Console.WriteLine($"The {this.GetType().Name} is started!");
        }

        public virtual void stop()
        {
            Console.WriteLine($"The {this.GetType().Name} is stoped!");
        }

        public virtual void takeoff()
        {
            Console.WriteLine($"The {this.GetType().Name} is takeoff!");
        }

        public virtual void land()
        {
            Console.WriteLine($"The {this.GetType().Name} is takeoff!");
        }

        

    }
}
