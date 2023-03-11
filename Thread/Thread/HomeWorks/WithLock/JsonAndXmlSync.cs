using ThreadLesson.HomeWorks.Jsons;
using ThreadLesson.HomeWorks.Xmls;

namespace ThreadLesson.HomeWorks.WithLock
{
    public class JsonAndXmlSync
    {
        RunTodo runTodoJson = new RunTodo();
        RunTodoXmls runTodoXmls = new RunTodoXmls();
        public void Run()
        {

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Edit");
            Console.WriteLine("3.Delete");
            Console.WriteLine("4.Exit");
            Console.Write("Number: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Number is errored!");
            }
            bool flag = true;
            while (flag)
            {
                switch (num)
                {
                    case 1: AddJsonAndXml(); break;
                    case 2: EditJsonAndXml(); break;
                    case 3: RemoveJsonAndXml(); break;
                    case 4: flag = false; break;
                    default:
                        break;
                }
            }


        }

        public MyTodoClass EnterClass()
        {
            MyTodoClass myTodoClass = new MyTodoClass();
            Console.Write("Title: ");
            myTodoClass.title = Console.ReadLine();
            Console.Write("is Completed?, True or False: ");
            myTodoClass.completed = Convert.ToBoolean(Console.ReadLine());
            return myTodoClass;
        }
        public void AddJsonAndXml()
        {

            MyTodoClass myTodoClass = new MyTodoClass();
            myTodoClass = EnterClass();
            object iLock = new();
            Thread threadJson = new(do1);
            Thread threadXml = new(do2);
            threadJson.Start();
            threadXml.Start();

            void do1()
            {
                lock (iLock)
                {
                    runTodoJson.AddNewTodo(myTodoClass);
                }
            }

            void do2()
            {
                lock (iLock)
                {
                    runTodoXmls.addXmlTodo(myTodoClass);
                }
            }

        }

        public void EditJsonAndXml()
        {
            Console.Write("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());

            MyTodoClass myTodoClass = new MyTodoClass();
            myTodoClass = EnterClass();

            object iLock = new();
            Thread threadJson = new(do1);
            Thread threadXml = new(do2);
            threadJson.Start();
            threadXml.Start();
            void do1()
            {
                lock (iLock)
                {
                    runTodoXmls.EditXml(myTodoClass, id);

                }
            }
            void do2()
            {
                lock (iLock)
                {
                    runTodoJson.EditTodo(myTodoClass, id);

                }
            }


        }

        public void RemoveJsonAndXml()
        {
            Console.Write("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());
            object iLock = new();
            Thread threadJson = new(do1);
            Thread threadXml = new(do2);
            threadJson.Start();
            threadXml.Start();
            void do1()
            {
                lock (iLock)
                {
                    runTodoXmls.DeleteTodo(id);

                }
            }
            void do2()
            {
                lock (iLock)
                {
                    runTodoJson.DeleteTodo(id);

                }
            }

        }

    }
}
