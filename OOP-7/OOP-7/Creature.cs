using OOP_7.Interface;

namespace OOP_7
{
    public class Creature
    {
       abstract public class Animal
        {
            public abstract void Sound();
            
            public class Insects
            {
                public int legs { get; set; }
                public int eyes { get; set; }
                public string Color { get; set; }

                public void walking()
                {
                    //ReferenceEquals(AbandonedMutexException, B);
                    Console.WriteLine($"{GetType().Name} is walking");
                }

                public class Spider : Insects, IDanger
                {
                    public bool isDanger { get; set; }
                    public string typeOfSpider { get; set; }




                }
                public class Snail : Insects
                {

                }

            }
            public class Fishes
            {
                public string Color { get; set; }
                public double Lenght { get; set; }
                public double Weight { get; set; }

                public class Acula : Fishes, IDanger
                {
                    public bool isDanger { get; set; }

                }
                public class Dolphine : Fishes
                {

                }



            }
            public class Birds
            {
                private bool Isfly = true;
                public string Color { get; set; }



                public class Parrot:Birds
                {

                }
                public class Bat :Birds, IDanger
                {
                    public bool isDanger { get; set; }

                }
                public class camelBird : Birds
                {
                    public camelBird()
                    {
                        base.Isfly = false;
                    }


                }

            }


        }
        abstract public class Humans
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public string colorOfHair { get; set; }
            public int age { get; set; }
            public bool isMarried { get; set; }


            public class Male : Humans
            {

            }
            public class Female : Humans
            {

            }


        }

    }
}
