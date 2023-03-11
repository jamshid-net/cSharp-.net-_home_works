namespace Vazifa1
{
    public class Point
    {
        private int x;
        private int y;
        

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public Point()
        {

        }

        public void PrintXY()
        {
            Console.WriteLine($"({this.x}, {this.y})");
            

        }
    }

    class Uchburchak
    {
        public int a;
        public int b;
        public int c;


        public int aaa()
        {
            int s;
            if (a < b + c && b < c + a && c < b + a)
            {
                s = a + b + c;
                return s;
            }
            else
            {
                s = 0;
                return s;
            }

        }

        public void Peremiter()
        {
            if (aaa() > 0)
            {
                Console.WriteLine("Uchburchak peremetri: " + aaa());
            }

            else
            {
                Console.WriteLine("Uchburchak tomonlari notogri kirtildi");


            }

        }

        public void Area()
        {


            if (aaa() > 0)
            {
                double p = aaa() / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Yuzasi: " + area);
            }
            else
            {
                Console.WriteLine("Uchburchak tomonlari notogri kirtildi");
            }
        }



    }

    class MyClass
    {
        public int First;
        public int Second;

        public void AboutFields()
        {
            Console.WriteLine("Firts: "+this.First);
            Console.WriteLine("Second: "+this.Second);
        }
        public void SumOfFields()
        {
            Console.WriteLine("Sum of fields:" + (this.First+Second));
        }
        public void MaxOfFields()
        {
            if(this.First > this.Second)
            Console.WriteLine("Max is Firts: "+this.First);
            if(this.First<this.Second)
                Console.WriteLine("Max is Second: "+this.Second);
            else Console.WriteLine("They are equal");
        }

    }

    class Mydate
    {
        private int day = DateTime.Now.Day;
        private int month = DateTime.Now.Month;
        private int year = DateTime.Now.Year;
        public void DatePrint()
        {
            Console.WriteLine($"date is :{this.day}.{this.month}.{this.year}");
        }

    }

    class Student
    {
        public string FirtsName;
        public string LastName;
        private int age;
        public string group;
        public string[] items;
        
        
        public void SetAge(int age1)
        {
            this.age = age1;
        }
        
        public void PrintItems()
        {
            Console.WriteLine("Ismi: "+this.FirtsName);
            Console.WriteLine("Familyasi: "+this.LastName);
            Console.WriteLine("Yoshi: "+this.age);
            Console.WriteLine("Gruppasi: " + this.group);
            foreach (var item in this.items)
            {
                Console.WriteLine(item+" ");
            }

        }



    }








}




