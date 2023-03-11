using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson.OnLesson
{
    internal class OnLessonLinq
    {
    }
    public class TodoItem
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
    public class TodoItem2
    {
        public int userId { get; set; }
        public int id { get; set; }
        public bool completed { get; set; }

        public void MyMethod()
        {
            string Path = @"D:\ForGitHub\LinqLesson\LinqLesson\Json\todos.json";
            string Path2 = @"D:\ForGitHub\LinqLesson\LinqLesson\Json\todos2.json";
            string Path3 = @"D:\ForGitHub\LinqLesson\LinqLesson\Json\todos3.json";

            List<TodoItem>? todoItems = new List<TodoItem>();
            todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(File.ReadAllText(Path));

            var ids = from item in todoItems select item.id;
            foreach (var item in ids)
            {
                Console.WriteLine("Ids: " + item);
            }
            List<TodoItem2> todosWithoutTitle = (from item in todoItems
                                                 select new TodoItem2()
                                                 {
                                                     id = item.id,
                                                     completed = item.completed,
                                                     userId = item.userId
                                                 }).ToList();
            var query = (from item in todoItems?.Select((value, index) => new { value, index })
                         select new
                         {
                             Pindex = item.index,
                             id = item.value.id,
                             title = item.value.title

                         }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine("index:" + item.Pindex + " Title: " + item.title);
            }

            string? json2 = "";
            if (!File.Exists(Path2))
            {
                File.Create(Path2).Dispose();
            }
            json2 = JsonConvert.SerializeObject(todosWithoutTitle, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(Path2))
            {
                sw.Write(json2);

            }

            var MethodSyntax = todoItems.Select(item => item.id).ToList();
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }
            var MethodSyntaxWithoutTitle = todoItems.Select(item => new TodoItem2()
            {
                id = item.id,
                completed = item.completed,
                userId = item.userId
            });
            string json3 = JsonConvert.SerializeObject(MethodSyntaxWithoutTitle, Formatting.Indented);
            if (!File.Exists(Path3))
            {
                File.Create(Path3).Dispose();
            }
            using (StreamWriter writer = new(Path3))
            {
                writer.Write(json3);
            }

        }
    }
}
