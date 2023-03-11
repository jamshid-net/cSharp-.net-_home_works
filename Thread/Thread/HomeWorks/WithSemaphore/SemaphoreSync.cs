using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadLesson.HomeWorks.Jsons;
using ThreadLesson.HomeWorks.Xmls;

namespace ThreadLesson.HomeWorks.WithSemaphore
{
    internal class SemaphoreSync
    {

        RunTodo runTodoJson = new RunTodo();
        RunTodoXmls runTodoXmls = new RunTodoXmls();
        Semaphore sem = new(1,1);
        

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


        public void AddJsonAndXml()
        {

            MyTodoClass myTodoClass = new MyTodoClass();
            Console.Write("Title: ");
            myTodoClass.title = Console.ReadLine();
            Console.Write("is Completed?, True or False: ");
            myTodoClass.completed = Convert.ToBoolean(Console.ReadLine());
            object iLock = new();
            Thread threadJson = new(do1);
            Thread threadXml = new(do2);
            threadJson.Start();
            threadXml.Start();
            
            void do1()
            {

                sem.WaitOne();
                runTodoJson.AddNewTodo(myTodoClass);
                Thread.Sleep(5000);
                sem.Release();

            }

            void do2()
            {
                sem.WaitOne();
                runTodoXmls.addXmlTodo(myTodoClass);
                Thread.Sleep(5000);
                sem.Release();

            }

        }

        public void EditJsonAndXml()
        {
            Console.Write("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());

            MyTodoClass myTodoClass = new MyTodoClass();
            Console.Write("Title: ");
            myTodoClass.title = Console.ReadLine();
            Console.Write("is Completed?, True or False: ");
            myTodoClass.completed = Convert.ToBoolean(Console.ReadLine());

            object iLock = new();
            Thread threadJson = new(do1);
            Thread threadXml = new(do2);
            threadJson.Start();
            threadXml.Start();
            void do1()
            {

                sem.WaitOne();
                runTodoJson.EditTodo(myTodoClass,id);
                sem.Release();

            }

            void do2()
            {
                sem.WaitOne();
                runTodoXmls.EditXml(myTodoClass,id);
                sem.Release();

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

                sem.WaitOne();
                runTodoJson.DeleteTodo(id);
                sem.Release();

            }

            void do2()
            {
                sem.WaitOne();
                runTodoXmls.DeleteTodo(id);
                sem.Release();

            }
        }
    }
}
