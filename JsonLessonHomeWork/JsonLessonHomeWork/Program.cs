using JsonLessonHomeWork.Task1_HomeWork;
using JsonLessonHomeWork.task3_Home_Work;
using JsonLessonHomeWork.TodoHw;
using Newtonsoft.Json;
namespace JsonLessonHomeWork
{
    internal class Program
    {

        static void Main()
        {
            RunTodo runTodo = new RunTodo();
            runTodo.EditTodo(180);
           
            //runTodo.DeleteTodo(202);
            //ForRun forRun = new ForRun();
            //forRun.Run();
            //Search search = new Search();
            // search.start("Maxime_Nienow");

        }

    }

}