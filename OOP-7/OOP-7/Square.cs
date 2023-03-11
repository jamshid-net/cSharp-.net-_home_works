using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    public class Square
    {
        public int A { get; set; }
        public int B { get; set; }

        
        public Square() 
        {
            
        
        
        }
        public Square(int a , int b) 
        {
            A = a;
            B = b;

        
        
        }
        public static Square operator --(Square s)
        {
            s.A--;
            s.B--;
            return s;
        }
        public static Square operator ++(Square s)
        {
            s.A++;
            s.B++;
            return s;

        }
        public static Square operator /(Square s, Square s1)
        {
            Square s2 = new Square();
            s2.A = s.A / s1.A;
            s2.B = s.B / s1.B;
            return s2;
        }

        public override bool Equals(object? obj)
        {
            
            return ((Square)obj).A == A && ((Square)obj).B == B;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Square s, Square s1)
        {
            
            return s1.Equals(s);

        }
       
        public static bool operator !=(Square s,Square s1)
        {
            
            return !s1.Equals(s);

        }
        
        public override string ToString()
        {
            return $"A={A} va B={B}";
        }
       

    }
}
