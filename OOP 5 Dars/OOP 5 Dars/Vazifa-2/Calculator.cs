namespace OOP_5_Dars.Vazifa2
{
    static class Calculator
    {
        
        public static int add(int a, int b)
        {
                
            return a + b;
        }
        public static double add(double a, double b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }
        public static double sub(double a, double b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static double multiply(double a, double b)
        {
            return a * b;
        }
        public static int div(int a, int b)
        {
            return a / b;
        }
        public static double div(double a, double b)
        {
            return a / b;
        }
        public static int abs(int a)
        {
            if (a < 0) return -1 * a;
            else return a;
        }
        public static double abs(double a)
        {
            if (a < 0) return -1 * a;
            else return a;
        }
        public static int pow(int a)
        {
            return a * a;
        }

        public static double pow(double a)
        {
            return a * a;
        }






    }
 
}
