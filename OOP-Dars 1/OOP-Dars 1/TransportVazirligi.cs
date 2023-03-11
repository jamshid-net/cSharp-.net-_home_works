namespace TrasportVazirligi
{
    namespace AvtomobilTransporti
    {
        public class KattaAvtobus
        {

            public int TransportlarSoni;
            private string Modeli = "Mercedes";
            public string speed = "Max speed is 150km/h";
            public KattaAvtobus(string modeli)
            {
                this.Modeli = modeli;
            }
            public KattaAvtobus()
            {

            }

            public void GetInforMationAuto()
            {
                Console.WriteLine($"modeli: {this.Modeli} \n Max tezligi: {this.speed} \n Avtobuslar soni:{this.TransportlarSoni} ");
            }



        }
        public class KichikAvtobus
        {

            public int TransportlarSoni;
            private string Modeli = "Isuzu";
            public string speed = "Max speed is 180km/h";
            public KichikAvtobus(string modeli)
            {
                this.Modeli = modeli;
            }
            public KichikAvtobus()
            {

            }
            public void GetInforMationAuto()
            {
                Console.WriteLine($"modeli: {this.Modeli} \n Max tezligi: {this.speed} \n Avtobuslar soni:{this.TransportlarSoni} ");
            }


        }



    }
    namespace HavoTransporti
    {
        class Samolyot
        {
            public int TransportlarSoni;
            public string Modeli = "Boing 787";

            public Samolyot(string modeli)
            {
                this.Modeli = modeli;
            }
            public Samolyot()
            {

            }

            public void GetInforMationAuto()
            {
                Console.WriteLine($"modeli: {this.Modeli} \n samolyotlar soni:{this.TransportlarSoni} ");
            }
        }

    }
    namespace TemiryolTransporti
    {
        class Poyezd
        {
            public int TransportlarSoni;
            private string Modeli = "Afrosiyob";
            public Poyezd(string modeli)
            {
                this.Modeli = modeli;
            }
            public Poyezd()
            {

            }
            public void GetInforMationAuto()
            {
                Console.WriteLine($"modeli: {this.Modeli} \n Poyezdlar soni:{this.TransportlarSoni} ");
            }
            public class Afff
            {
                public string bb = "";

            }
            

        }
        class Metro
        {
            public int TransportlarSoni;
            private string Modeli = "Metro";
            public Metro(string modeli)
            {
                this.Modeli = modeli;
            }
            public Metro()
            {

            }
            public void GetInforMationAuto()
            {
                Console.WriteLine($"modeli: {this.Modeli} \n Vagonlar soni:{this.TransportlarSoni} ");
            }
        }

    }
    namespace DaryoTransporti
    {
        class Kema
        {
            public int TransportlarSoni;
            private string Modeli = "F-155457";
            public Kema(string modeli)
            {
                this.Modeli = modeli;
            }
            public Kema()
            {

            }
            public void GetInforMationAuto()
            {
                Console.WriteLine($"modeli: {this.Modeli} \n Kemalar soni:{this.TransportlarSoni} ");
            }
        }


    }

}
