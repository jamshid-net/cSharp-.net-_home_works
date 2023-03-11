using OOP_6.Task_1.Interface;

namespace OOP_6.Task_1.Classes
{
    abstract class Shape : IArea, IColor
    {
        

        public abstract double Area();
        public abstract string getColor();
        public string Color { get; set; }

        public Shape() : this("red")
        {

        }
        public Shape(string color)
        {
            this.Color = color;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{this.GetType().Name} of area = {Area()}");
            Console.WriteLine($"{this.GetType().Name} of color is = {getColor()}");
        }


    }
}
