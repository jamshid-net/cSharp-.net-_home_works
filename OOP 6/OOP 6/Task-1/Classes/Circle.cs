using OOP_6.Task_1.Interface;

namespace OOP_6.Task_1.Classes
{
    class Circle : Shape, IArea, IColor
    {
        private const float PI = 3.14f;
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                    _radius = value;

                while (Radius <= 0)
                {
                    Console.WriteLine("Radius not should be <0");
                    Radius = Convert.ToDouble(Console.ReadLine());
                }

            }
        }

        public override double Area()
        {
            return PI * (Math.Pow(_radius, 2));
        }

        public override string getColor()
        {
            return Color;
        }
        public Circle() : base()
        {

        }
        public Circle(string color) : base(color)
        {

        }
        public Circle(string color, double radius = 0) : base(color)
        {
            Radius = radius;
            base.Color = color;
        }
        







    }
}
