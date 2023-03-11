using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace OOP_6.Новая_папка
{
    internal class Class1
    {

        public int MyProperty { get; set; }

        partial class parNes : Class1
        {

        }

        partial class parNes
        {
           
        }


    }

   public class abs
    {
        public int number { get; set; }

        
    }

    public class Numb : abs
    {
        public string name { get; set; }
    }

  public static class test
    {
       

      public  static class numm
        {
            public static int n { get; private set; }
           public static void Set(Numb num)
            {
                
                n = num.number;
               
            }
           

        }
    }

    public class forCast
    {
        public int a { get; set; }
        public int b { get; set; }

        public static forCast  operator --(forCast obj)
        {
            obj.a--;
            obj.b--;
            return obj;
        }
        public static forCast  operator ++(forCast obj)
        {
            obj.a++;
            obj.b++;
            return obj;
        }

        public static bool operator <= (forCast obj, forCast obj2)
        {
           return obj.a<=obj2.a && obj.b<=obj2.b;

        }
         public static bool operator >= (forCast obj, forCast obj2)
        {

            return obj.a >= obj2.a && obj.b >= obj2.b;
        }

       


    }
}
