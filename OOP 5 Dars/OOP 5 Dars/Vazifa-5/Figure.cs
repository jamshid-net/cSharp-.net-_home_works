namespace OOP_5_Dars.Vazifa_5
{
    class Figure
    {

        private protected double _area { get; set; }
        private protected double _perimeter { get; set; }
        public virtual void area()
        {
            Console.WriteLine($"Surface of {this.GetType().Name} = {_area} ");
        }
        public virtual void perimeter()
        {
            Console.WriteLine($"Perimeter of {this.GetType().Name} = {_perimeter} ");
        }

    }
    class Cirlce : Figure
    {
        private const float PI = 3.14f;
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                while (Radius <= 0)
                {
                    Console.WriteLine("Radiusni qaytadan kiriting!");
                    Radius = Convert.ToDouble(Console.ReadLine());
                }

            }
        }
        public override void area()
        {
            _area = PI * (radius * radius);
            base.area();
        }
        public override void perimeter()
        {
            _perimeter = 2.0 * PI * radius;
            base.perimeter();
        }

    }
    class Triangle : Figure
    {
        private double _sideA;

        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (value > 0)
                    _sideA = value;

                while (SideA <= 0)
                {
                    Console.WriteLine("SideA ni qaytadan kiriting!");
                    SideA = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        private double _sideB;
        

        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value > 0)
                    _sideB = value;

                while (SideB <= 0)
                {
                    Console.WriteLine("SideB ni qaytadan kiriting!");
                    SideB = Convert.ToDouble(Console.ReadLine());
                }


            }
        }
        
        public override void area()
        {
            _area = (_sideB * _sideA) / 2.0;
            base.area();
        }
        public override void perimeter()
        {
            double _hipotenuse = Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2));
            _perimeter = _sideA + _sideB + _hipotenuse;
            base.perimeter();
        }
        

    }
    class Rectangle : Figure
    {
        private double _sideA;

        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (value > 0)
                    _sideA = value;

                while (SideA <= 0)
                {
                    Console.WriteLine("SideA ni qaytadan kiriting!");
                    SideA = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        private double _sideB;

        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value > 0)
                    _sideB = value;

                while (SideB <= 0)
                {
                    Console.WriteLine("SideB ni qaytadan kiriting!");
                    SideB = Convert.ToDouble(Console.ReadLine());
                }


            }
        }

        public override void area()
        {
            _area = _sideB * _sideA;
            base.area();
        }
        public override void perimeter()
        {

            _perimeter = (_sideA * 2.0) + (_sideB * 2.0);
            base.perimeter();
        }

    }

}
