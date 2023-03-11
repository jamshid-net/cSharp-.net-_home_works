using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_2.Interface
{
    interface  IPlane
    {
        void start();
        void stop();
        void takeoff();
        void land();

    }
  interface IEngine
    {
       public abstract int hpEngine { get; }
       public abstract int countEngine {get;}
       public abstract string modelEngine { get; }

    }
}
