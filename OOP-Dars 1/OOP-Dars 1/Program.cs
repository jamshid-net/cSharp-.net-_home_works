
using System.Data;
using Vazifa1;



static void Vazifa1Method()
{
    Point p = new(1,6);
    
   


    
    p.PrintXY();

}


static void Vazifa2Method()
{
    Uchburchak Triangle = new();
    Triangle.a = 14;
    Triangle.c = 2;
    Triangle.b = 1;
    Triangle.Peremiter();
    Triangle.Area();
}
static void Vazifa3Method()
{
    MyClass myclass1 = new();
    myclass1.First = 15;
    myclass1.Second = 16;
    myclass1.AboutFields();
    myclass1.SumOfFields();
    myclass1.MaxOfFields();

}

static void Vazifa4Method()
{
    Mydate mydate1 = new();
    mydate1.DatePrint();
}

static void Vazifa5Method()
{
    Student student = new();
    student.FirtsName = "Jonh";
    student.LastName = "Mikes";
    student.SetAge(22);
    student.group = "T221";
    student.items = new string[] { "Operation System", "DateBase", "Computer science", "algorithms", "Cyber Security" };

    student.PrintItems();

}


double a = 1.0 / 2;
Console.WriteLine(a);

