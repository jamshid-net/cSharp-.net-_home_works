using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dars_2
{

    class myClass
    {
       public int age
        {
            get
            {
                if(age1>0) return age1;
                return age1;
            }
            
            set 
            {

                if (value > 0) { age1 = value; }
                else Console.WriteLine("noo");
            }
        }
        private int age1;



       
    }
}
