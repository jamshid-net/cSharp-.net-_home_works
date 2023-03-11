using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Delegate
{
     record Mrrr(string name, int age);
    

    class MyclassDelegate
    {
        public delegate void delegat(string s);

        public static delegat de = delegate (string s)
        {

            Console.WriteLine("It is anonym method  "+s);

        };
        public delegate int TestDelgate(int num);
        public static TestDelgate del = (num) => num * num;

        public static void run()
        {
            de("added text");
            int f = del(15);
            Console.WriteLine(f);
        }


    }
        record  Myrecord ( string name, int age, int id );
    class myGenericDelegat 
    {
        Func<string, int> func = (string s) => s.Length;
        
         
        

        public void Run()
        {
            Myrecord myrecord = new("Mike",25,998);
            Func<Myrecord> func2 = () => myrecord;
            string d =func2().ToString();
            Console.WriteLine(d);
            //Console.WriteLine(d);
            //Action action2 = () => Console.WriteLine("HEllo");
            //action2();
         //   rec.age


        }
    
    
    }



    internal class Mathematics
    {
        public delegate int MathDelegat(int n);
        public static int Sum(int num)
        {
            return num + 2;
        }
        public static int Subtract(int num)
        {
            return num - 2;
        }
        public static int Multipy(int num)
        {
            return num * 2;
        }
        public static int Divide(int num)
        {
            return num / 2;
        }
        public string Test(string mess)
        {
            return "hello";
        }

    }

    class MathDel
    {
        public delegate int Matem(int n);
        public Matem sum = num => num + 2;
        public Matem subs = num => num - 2;
        public Matem multipy = num => num * 2;
        public Matem divede = num => num / 2;
        public void Run()
        {

        }

    }
}
