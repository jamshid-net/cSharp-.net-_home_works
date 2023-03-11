namespace OOP_5_Dars.Vazifa_4
{

    class Animal
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { if (age > 0) age = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        private protected bool isTrue;
     
        public void GetCountLegs()
        {
            int legs = 2;
            if(isTrue) legs= 4;
            Console.WriteLine($"{legs} oyoqli {this.GetType().Name}");

        }

        public virtual void sound()
        {
            Console.WriteLine("sound!");
        }

    }
    class Dog : Animal
    {
        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        public Dog()
        {
            isTrue = true;
        }
        public override void sound()
        {
            Console.WriteLine("wof wof");
        }
    }
    class Cat : Animal
    {
        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public Cat()
        {
            isTrue = true;
        }
        public override void sound()
        {
            Console.WriteLine("meow meow");
        }

    }
    class Duck1 : Animal
    {
        public Duck1()
        {
            isTrue = false;

        }
        public override void sound()
        {
            Console.WriteLine("quack quack!");
        }
    }






}


