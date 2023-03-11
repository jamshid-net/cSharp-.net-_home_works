namespace OOP_5_Dars.Vazifa_1
{
    class AddAttribut
    {
        protected int a;
        protected int b;

        public AddAttribut(int x = 0, int y = 0)
        {
            this.a = x;
            this.b = y;
        }

        public virtual string Add()
        {
            return (a + b).ToString();


        }
        
    }
    class AddAttribut1 : AddAttribut
    {
        protected new double b;

        public AddAttribut1(int a = 0, double b = 0) : base(a)
        {
            this.b = b;
        }

        public override string Add()
        {
            return (b + Convert.ToDouble(a)).ToString();
        }



    }
    class AddAttribut2 : AddAttribut1
    {
        protected new double a;
        protected double c;

        public AddAttribut2(double a = 0, double b = 0, double c = 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override string Add()
        {
            return (a + b + c).ToString();

        }

    }
    class AddAttribut3: AddAttribut2
    {
        protected  new string a;
        protected new string b;
        

        public AddAttribut3(string a = "", string b ="")
        {
            this.a = a;
            this.b = b;
        }
        public override string Add()
        {
            return a+" "+b;
        }

    }
    class AddAttribut4 : AddAttribut3
    {
        protected new int a;
        public AddAttribut4(int a = 0, string b = "")
        {
            this.a = a;
            this.b = b;
        }
        public  override sealed string Add()
        {
            return a.ToString()+b;
        }


    }

}
