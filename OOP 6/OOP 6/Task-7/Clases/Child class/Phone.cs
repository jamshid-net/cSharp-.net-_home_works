using OOP_6.Task_7.Clases.Father_class;
using OOP_6.Task_7.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_7.Clases.Child_class
{
    internal class Phone : Texnika, IElektronika ,IMahsulot
    {

        public string model { get; set; }
        public double price { get; set; }
        public double diplaySize { get; set; }
        public string madeIn { get; set; }  
        public double volt { get; set; }

        public override void Start() => Console.WriteLine("The phone is unlocked");
       
        public override void Stop() => Console.WriteLine("The phone is locked");


    }
}
