using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadLesson.HomeWorks.Jsons;
using ThreadLesson.HomeWorks.Xmls;

namespace ThreadLesson.HomeWorks.WithMonitoring
{
    internal class JsonAndXmlMonitoring
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
                bool acquiredLock = false;
                try
                {
                    Monitor.Enter(iLock, ref acquiredLock);
                    runTodoJson.AddNewTodo(myTodoClass);
                   
                }
                finally 
                {
                   
                    if (acquiredLock) Monitor.Exit(iLock);
                 
                }
                
            }

            void do2()
            {
                bool acquiredLock = false;
                try
                {
                    Monitor.Enter(iLock, ref acquiredLock);
                    runTodoXmls.addXmlTodo(myTodoClass);

                }
                finally
                {
                   
                    if (acquiredLock) Monitor.Exit(iLock);
                  
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
                bool acquiredLock = false;
                try
                {
                    
                    Monitor.Enter(iLock, ref acquiredLock);
                    runTodoJson.EditTodo(myTodoClass,id);

                }
                finally
                {
                    if (acquiredLock) Monitor.Exit(iLock);
                }

            }

            void do2()
            {
                bool acquiredLock = false;
                try
                {
                    Monitor.Enter(iLock, ref acquiredLock);
                   runTodoXmls.EditXml(myTodoClass,id);

                }
                finally
                {
                    if (acquiredLock) Monitor.Exit(iLock);
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
                bool acquiredLock = false;
                try
                {
                    Monitor.Enter(iLock, ref acquiredLock);
                    runTodoJson.DeleteTodo(id);

                }
                finally
                {
                    if (acquiredLock) Monitor.Exit(iLock);
                }

            }

            void do2()
            {
                bool acquiredLock = false;
                try
                {
                    Monitor.Enter(iLock, ref acquiredLock);
                    runTodoXmls.DeleteTodo(id);

                }
                finally
                {
                    if (acquiredLock) Monitor.Exit(iLock);
                }

            }
        }
    }
}
