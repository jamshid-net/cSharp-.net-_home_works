using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLessonHomeWork.TodoHw
{
    class RunTodo
    {
        public static string PATH = @"D:\ForGitHub\JsonLessonHomeWork\JsonLessonHomeWork\TodoHw\todos.json";
        public List<MyTodoClass>? myTodoClasses=  JsonConvert.DeserializeObject<List<MyTodoClass>>(File.ReadAllText(PATH));
        public void GetCompletedTasks()
        {
            


            Console.WriteLine("Completed Tasks: ");
            myTodoClasses?.ForEach(x =>
            {
                if (x.completed)
                {
                    Console.WriteLine($"UserId:{x.userId}, id:{x.id} :" + x.title );
                }

            });

          

        }

        public void GetNotCompletedTasks()
        {
            Console.WriteLine("Not Completed Tasks: ");
            myTodoClasses?.ForEach(x =>
            {
                if (!x.completed)
                {
                    Console.WriteLine($"UserId:{x.userId}, id:{x.id} :" + x.title);
                }

            });
        }
        public void AddNewTodo()
        {
            MyTodoClass myTodoClass = new MyTodoClass();
           
            
            myTodoClass.id = myTodoClasses.Last().id + 1;
            myTodoClass.userId = (myTodoClasses.Last().id/20)+1;
            Console.Write("Title: ");
            myTodoClass.title = Console.ReadLine();
            Console.Write("is Completed?");
            myTodoClass.completed = Convert.ToBoolean(Console.ReadLine());

            myTodoClasses.Add(myTodoClass);

            string myNewJson = JsonConvert.SerializeObject(myTodoClasses,Formatting.Indented);
            using(StreamWriter writer = new(PATH))
            {
                writer.Write(myNewJson);
            }



        }
        public void DeleteTodo(int id)
        {
           myTodoClasses.Remove( myTodoClasses.Find(x => x.id == id));
            string myNewJson = JsonConvert.SerializeObject(myTodoClasses, Formatting.Indented);
            using (StreamWriter writer = new(PATH))
            {
                writer.Write(myNewJson);
            }
        }
        public void EditTodo(int id)
        {
            int UserId = myTodoClasses.Find(x => x.id == id).userId;
            MyTodoClass todoClass = myTodoClasses.Find(x=>x.id == id);
            Console.Write("edit title: ");
            todoClass.title = Console.ReadLine();
            Console.Write("edit completed true or false?");
            todoClass.completed = Convert.ToBoolean(Console.ReadLine());
            int index =  myTodoClasses.FindIndex(x => x.id == id);
            todoClass.id = id;
            todoClass.userId = UserId;
            myTodoClasses[index] = todoClass;
            string myNewJson = JsonConvert.SerializeObject(myTodoClasses, Formatting.Indented);
            using (StreamWriter writer = new(PATH))
            {
                writer.Write(myNewJson);
            }

        }

    }
}
