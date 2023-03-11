using ThreadLesson.HomeWorks.Jsons;
using ThreadLesson.HomeWorks.Xmls;

namespace ThreadLesson.HomeWorks.WithAutoResetEvent
{
    internal class AutoResetEventSnyc
    {
        RunTodo runTodoJson = new RunTodo();
        RunTodoXmls runTodoXmls = new RunTodoXmls();
        AutoResetEvent autoReset = new AutoResetEvent(true);

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

                autoReset.WaitOne();
                runTodoJson.AddNewTodo(myTodoClass);
                autoReset.Set();

            }

            void do2()
            {
                autoReset.WaitOne();

                runTodoXmls.addXmlTodo(myTodoClass);
                autoReset.Set();

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

                autoReset.WaitOne();
                runTodoJson.EditTodo(myTodoClass,id);
                autoReset.Set();

            }

            void do2()
            {
                autoReset.WaitOne();

                runTodoXmls.EditXml(myTodoClass,id);
                autoReset.Set();

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

                autoReset.WaitOne();
                runTodoJson.DeleteTodo(id);
                autoReset.Set();

            }

            void do2()
            {
                autoReset.WaitOne();

                runTodoXmls.DeleteTodo(id);
                autoReset.Set();

            }
        }
    }
}
