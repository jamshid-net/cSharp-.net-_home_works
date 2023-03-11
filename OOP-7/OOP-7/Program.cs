namespace OOP_7
{
    internal class Program
    {
        static void Main()
        {

            Square obj = new Square();
            obj.A = 25;
            obj.B = 2;


            Square obj2 = new Square();
            obj2.A = 25;
            obj2.B = 2;


           bool f = obj.Equals(obj2);
            Console.WriteLine(f);











        }
    }
}