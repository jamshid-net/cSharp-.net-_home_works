using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_4
{
    class Student :Person
    {
        public string Degree { get; set; }
        public string Major { get; set; }

        public Student(string degre = "no degree", string major="no major") : base()
        {
           
            this.Degree = degre;
            this.Major = major;
            
        }
    }
}
