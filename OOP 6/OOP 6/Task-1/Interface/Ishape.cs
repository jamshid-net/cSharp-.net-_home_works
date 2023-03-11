using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_1.Interface
{
    interface IArea
    {
        double Area();
        void DD()
        {
            Console.WriteLine("FFFFF");
        }
    }
    interface IColor
    {
        string Color { get; }
        string getColor()
        {
            return Color;
        }

    }
}
