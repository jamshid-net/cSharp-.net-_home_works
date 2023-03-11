using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ThreadLesson.HomeWorks.Xmls
{
    class RunTodoXmls
    {

        public static string PATH = @"D:\ForGitHub\Thread\Thread\HomeWorks\Files\todos.xml";

        public List<MyTodoClass>? myTodoClasses = new();
        public XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MyTodoClass>));

        public void Writer()
        {
            using (StreamWriter sw = new(PATH))
            {
                xmlSerializer.Serialize(sw, myTodoClasses);
            }
        }

        public void StreamWithOpen()
        {
            using (FileStream fs = new(PATH, FileMode.Open))
            {
                myTodoClasses = xmlSerializer.Deserialize(fs) as List<MyTodoClass>;
            }
        }
        public void addXmlTodo(MyTodoClass myTodoClass)
        {


            if (!File.Exists(PATH))
            {
                myTodoClass.id = 1;
                myTodoClass.userId = 1;

            }
            else
            {
                StreamWithOpen();
                myTodoClass.id = myTodoClasses.Last().id + 1;
                myTodoClass.userId = myTodoClasses.Last().id / 20 + 1;
            }

            myTodoClasses?.Add(myTodoClass);
            using (FileStream fs = new(PATH, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, myTodoClasses);
            }

        }
        public void EditXml(MyTodoClass todoClass, int id)
        {

            StreamWithOpen();

            todoClass.id = myTodoClasses.Find(x => x.id == id).id;
            todoClass.userId = myTodoClasses.Find(x => x.id == id).userId;

            int index = myTodoClasses.FindIndex(x => { return x.id == id; });
            myTodoClasses[index] = todoClass;
            Writer();

        }
        public void DeleteTodo(int id)
        {


            StreamWithOpen();
            myTodoClasses.Remove(myTodoClasses.Find(x => x.id == id));

            Writer();
        }



    }
}
