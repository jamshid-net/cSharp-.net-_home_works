using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{

    class Triangle
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Triangle()
        {

        }
        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void printxyz()
        {
            Console.WriteLine("{0}{1}{2}", x, y, z);
        }

        public static Triangle operator -(Triangle t)
        {
            Triangle temp = new();
            temp.x = -t.x;
            temp.y = -t.y;
            temp.z = -t.z;
            return temp;
        }
        public static Triangle operator ++(Triangle t)
        {
            Triangle temp = new();
            temp.x = t.x;
            temp.y = t.y;
            temp.z = t.z;
            temp.x++;
            temp.y++;
            temp.z++;
            return temp;

            
        }

        public static bool operator <=(Triangle t, Triangle t1)
        {

            if (t.x <= t1.x && t.y <= t1.y && t.z <= t1.z)
                return true;
            return false;

        }
        public static bool  operator >=(Triangle t, Triangle t1)
        {

            if (t.x >= t1.x && t.y >= t1.y && t.z >= t1.z)
                return true;
            return false;

        }
       

        public override string ToString()
        {
            return $"x={this.x} va y={this.y} va z={this.z}";
        }



    }

}
