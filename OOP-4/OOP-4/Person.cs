namespace OOP_4
{
    class Person
    {


        public Person()
        {
            counter++;
        }
        private static int counter;

        public static int Counter
        {
            get { return counter; }
           private set { counter = value; }
        }


        private int Age;

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string Nationality;

        public string nationality
        {
            get { return Nationality; }
            set { Nationality = value; }
        }
        public Person(int Age = 23, string name = "none", string nationality = "no national")
        {
            age = Age;
            Name = name;
            this.nationality = nationality;
        }
        private int GetAge()
        {
            return age;
        }
        

        public static Person PrintAgeStatus(Person pers)
        {
            if (pers.age >= 1 && pers.age <= 12) Console.WriteLine("yosh bola");
            if (pers.age > 12 && pers.age <= 18) Console.WriteLine("O'smir");
            if (pers.age > 18 && pers.age <= 30) Console.WriteLine("yosh");
            if (pers.age > 30 && pers.age <= 55) Console.WriteLine("voyaga yetgan");
            if (pers.age > 55) Console.WriteLine("qari");
            return pers;

        }
        




    }
}
