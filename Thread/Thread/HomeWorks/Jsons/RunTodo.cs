using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadLesson.HomeWorks;

namespace ThreadLesson.HomeWorks.Jsons
{
    class RunTodo
    {
        public static string PATH = @"D:\ForGitHub\Thread\Thread\HomeWorks\Files\todos.json";
        public List<MyTodoClass>? myTodoClasses = JsonConvert.DeserializeObject<List<MyTodoClass>>(File.ReadAllText(PATH));
        public void GetCompletedTasks()
        {
            Console.WriteLine("Completed Tasks: ");
            myTodoClasses?.ForEach(x =>
            {
                if (x.completed)
                {
                    Console.WriteLine($"UserId:{x.userId}, id:{x.id} :" + x.title);
                }

            });

        }
        public void Writer()
        {
            string myNewJson = JsonConvert.SerializeObject(myTodoClasses, Formatting.Indented);
            using (StreamWriter writer = new(PATH))
            {
                writer.Write(myNewJson);
            }
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
        public void AddNewTodo(MyTodoClass myTodoClass)
        {
            myTodoClass.id = myTodoClasses.Last().id + 1;
            myTodoClass.userId = myTodoClasses.Last().id / 20 + 1;


            myTodoClasses.Add(myTodoClass);
            Writer();



        }
        public void DeleteTodo(int id)
        {
            myTodoClasses.Remove(myTodoClasses.Find(x => x.id == id));
            Writer();
        }
        public void EditTodo(MyTodoClass myTodo, int id)
        {
            myTodo.id = myTodoClasses.Find(x => x.id == id).id;
            myTodo.userId = myTodoClasses.Find(x => x.id == id).userId;

            int index = myTodoClasses.FindIndex(x => x.id == id);

            myTodoClasses[index] = myTodo;
            Writer();

        }

    }
}
