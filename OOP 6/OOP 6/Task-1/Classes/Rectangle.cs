using OOP_6.Task_1.Interface;
using System.Drawing;

namespace OOP_6.Task_1.Classes
{
    class Rectangle:Shape, IArea, IColor
    {
        private double _length;

        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                    _length = value;

                while (Length <= 0)
                {
                    Console.WriteLine("Length not should be <0");
                    Length = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        private double _width;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;

                while (Width <= 0)
                {
                    Console.WriteLine("Width not should be <0");
                    Width = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        public override double Area()
        {
            return _width * _length;
        }

        public override string getColor()
        {
            return Color;
        }
        public Rectangle() : base()
        {

        }
        public Rectangle(string color) : base(color)
        {

        }
        public Rectangle(string color, double width = 0, double length = 0) : base(color)
        {
            Width = width;
            Length = length;
            base.Color = color;
        }

    }
}
