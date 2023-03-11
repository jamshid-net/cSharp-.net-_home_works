namespace OOP_3_dars
{
   class Animal
    {
        private int legs;

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        private string _ColorAnimal;

        public string ColorAnimal
        {
            get { return _ColorAnimal; }
            set { _ColorAnimal = value; }
        }



        private protected bool _isMammal = false;


        public void isMammal()
        {
            if (_isMammal) Console.WriteLine($"yes the animal is mammal");
            else Console.WriteLine("no the animal is not mammal");
        }




    }

    class Pet : Animal
    {
        private string nickNameOfAnimal;

        public string NickName
        {
            get { return nickNameOfAnimal; }
            set { nickNameOfAnimal = value; }
        }

    }
    class Bird : Animal
    {
        private double LenghtWing;

        public double LenghtOfWing
        {
            get { return LenghtWing; }
            set { LenghtWing = value; }
        }
        private protected bool _isFly = false;

        public void isFlyed()
        {
            if (_isFly) Console.WriteLine("Yeah, the bird is fly");
            else Console.WriteLine("No, the bird can't fly");
        }





    }
    class Cat : Pet
    {
        
        public Cat()
        {
            
            base._isMammal = true;
            base.Legs = 4;


        }
        public void catsSound() => Console.WriteLine("meow meow");


    }
    class Dog : Pet
    {
        public Dog()
        {
            base._isMammal = true;
            base.Legs = 4;

        }

        public void dogsSound() => Console.WriteLine("gaf-gaf");

    }

    class Cow : Pet
    {
        public Cow()
        {
            base._isMammal = true;
            base.Legs = 4;
        }
        public void coWSound() => Console.WriteLine("MoO moO");
    }
    class Straus :Bird
    {
        public Straus()
        {
            base._isMammal = false;
            base._isFly= false;
            base.Legs = 2;

        }

    }
    class Bat: Bird
    {
        public Bat()
        {
            base._isMammal = true;
            base.Legs = 2;
            base._isFly= true;
        }

    }
    class Eagle : Bird
    {

        public Eagle()
        {
            base._isMammal =false;
            base._isFly=true;
            base.Legs = 2;
        }

    }
}
