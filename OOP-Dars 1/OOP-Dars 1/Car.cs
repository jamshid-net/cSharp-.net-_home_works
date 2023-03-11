using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dars_1
{
    internal class Car
    {
        public string Color = "";
        public string Model = "";
        public int MaxSpeed;
        public void Start()
        {
            Console.WriteLine(this.Model +" "+ this.Color +" Car is Started!");

        }
        public void Stop()
        {
            Console.WriteLine("Car is Stopped!");
        }
    }
}

namespace OOp
{
    internal class Car
    {
        public string Color = "";
        public string Model = "";
        public int MaxSpeed;
        public void Start()
        {
            Console.WriteLine(this.Model + " " + this.Color + " Car is Started!");

        }
        public void Stop()
        {
            Console.WriteLine("Car is Stopped!");
        }
    }

}
