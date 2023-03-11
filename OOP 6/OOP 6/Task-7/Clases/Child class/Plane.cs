using OOP_6.Task_7.Clases.Father_class;
using OOP_6.Task_7.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_7.Clases.Child_class
{
    internal class Plane : Texnika, IFly ,IMahsulot , IElektronika
    {
        public bool isFly { get; set; }
        public string madeIn { get; set; }
        public double price { get; set; }
        public string model { get; set; }
        public double volt { get; set; }

    }
}
