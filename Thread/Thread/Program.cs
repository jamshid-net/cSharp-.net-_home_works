
using Newtonsoft.Json;
using ThreadLesson.HomeWorks;
using ThreadLesson.HomeWorks.WithAutoResetEvent;
using ThreadLesson.HomeWorks.WithLock;
using ThreadLesson.HomeWorks.WithMonitoring;
using ThreadLesson.HomeWorks.WithSemaphore;

namespace ThreadLesson
{
    internal class Program
    {
        static void Print() { Console.WriteLine("Hello Threads"); }
        static void CountUp(string name)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"{name} :  i={i}");

            }
            Console.WriteLine($"{Thread.CurrentThread.Name} is finished");

        }
        static void CountDown(string name)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"{name} :  i={i}");

            }
            Console.WriteLine($"{Thread.CurrentThread.Name} is finished");

        }


        static void Main()
        {
            //JsonAndXmlMonitoring jsonAndXmlMonitoring = new JsonAndXmlMonitoring();
            //jsonAndXmlMonitoring.Run();
            //JsonAndXmlSync jsonAndXml = new JsonAndXmlSync();
            //jsonAndXml.Run();
            //Console.WriteLine("main started");
            //Print2();
            //Console.WriteLine("main end");
            //Print3();
            //Console.ReadKey();

            //AutoResetEventSnyc autoReset = new AutoResetEventSnyc();
            //autoReset.Run();
            //SemaphoreSync sync = new SemaphoreSync();
            //sync.Run();
            MySemaphore();





        }

        async static Task Print2()
        {
            Console.WriteLine("Started");
            //  await Task.Delay(TimeSpan.FromSeconds(5));
            await Task.Run(() =>
            {
                Console.WriteLine("Hello");
                List<MyTodoClass> myClasses = new();
                myClasses = JsonConvert.DeserializeObject<List<MyTodoClass>>(File.ReadAllText(@"D:\ForGitHub\Thread\Thread\HomeWorks\Files\todos.json"));
                foreach (var item in myClasses)
                {
                    Console.WriteLine(item.title);
                }
            });

        }

        async static Task Print3()
        {
            Console.WriteLine("Print3 method is started");
           await Task.Delay(3000);
            Console.WriteLine("print3 fineshed");
        }
        static void ThreadProperties()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main";
            Console.WriteLine(thread.Name);
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine("using main thread id: " + thread.ManagedThreadId);
            Console.WriteLine(thread.Priority);

            ThreadStart threadStart = new(Main);

            Thread newThread = new(threadStart);
            Console.WriteLine(newThread.IsAlive);
            Console.WriteLine("new thread id: " + newThread.ManagedThreadId);

        }
        static void CreateThread()
        {
            ThreadStart mydelegate = Print;
            // ParameterizedThreadStart
            Thread myThread1 = new Thread(mydelegate);
            Thread myThread4 = new Thread(mydelegate, 1);
            Thread myThread2 = new Thread(new ThreadStart(Print));
            Thread myThread3 = new Thread((object? obj) => Console.WriteLine(obj + " Hello Threads"));

            myThread4.Start();
            myThread1.Start();  // запускаем поток myThread1
            myThread2.Start();  // запускаем поток myThread2
            myThread3.Start("salom");  // запускаем поток myThread3
        }
        static void MultiThreadWork()
        {
            // создаем новый поток
            Thread myThread = new Thread(Print);
            //myThread.Priority = ThreadPriority.Lowest;
            // запускаем поток myThread
            myThread.Start();

            // действия, выполняемые в главном потоке
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Главный поток: {i}");
                Thread.Sleep(300);
            }

            // действия, выполняемые во втором потокке
            void Print()
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"Второй поток: {i}");
                    Thread.Sleep(400);
                }
            }
        }
        static void SyncThreads()
        {
            int x = 0;
            object? locker = new();
            // запускаем пять потоков
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {i}";   // устанавливаем имя для каждого потока
                myThread.Start();
            }

            void Print()
            {
                lock (locker)
                {
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                        x++;
                        
                    }
                }
            }
        }
        static void LockSyncThreads()
        {
            int x = 0;

            object locker = new();  // объект-заглушка
            object locker2 = new();  // объект-заглушка
                                     // запускаем пять потоков
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                if (i % 2 == 0)
                {
                    myThread = new(Print);
                }
                else
                {
                    myThread = new(Print2);
                }
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }


            void Print()
            {
                lock (locker)
                {
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {

                        Console.WriteLine($"Print: {Thread.CurrentThread.Name}: {x}");
                        x++;
                        Thread.Sleep(100);

                    }
                }
            }
            void Print2()
            {
                lock (locker2)
                {
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"Print2: {Thread.CurrentThread.Name}: {x}");
                        x++;
                        Thread.Sleep(100);
                    }
                }
            }
        }
        static void UsingMonitor()
        {
            int x = 0;
            object locker = new();  // объект-заглушка
                                    // запускаем пять потоков
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }

            void Print()
            {
                bool acquiredLock = false;
                try
                {
                    Monitor.Enter(locker, ref acquiredLock);
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                        x++;
                        Thread.Sleep(100);
                    }
                    Console.WriteLine($"AcquiredLock:{acquiredLock}");
                }
                finally
                {
                  if (acquiredLock) Monitor.Exit(locker);
                }
            }
        }

        static void PrintNumberUsingMonitor()
        {
            object locker = new();
            
           
            Console.WriteLine($"{Thread.CurrentThread.Name} trying enter in to session");
            try
            {
               
                Monitor.Enter(locker);
                Console.WriteLine($"{Thread.CurrentThread.Name} is entered the session");
                for (int i = 0; i < 6; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(Thread.CurrentThread.Name+": i="+i);
                }
                Console.WriteLine();


            }
            finally
            {
                Monitor.Exit(locker);
                Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");

            }

            


        }
        static void InterlockedIncrement()
        {
            int count = 0;

            for (int i = 0; i < 100; i++)
            {
                Interlocked.Increment(ref count);
            }

            Console.WriteLine("Count = {0}", count);

        }
        static void myAutoResetEvent()
        {
            int x = 0;  // общий ресурс

            AutoResetEvent waitHandler = new AutoResetEvent(true);  // объект-событие

            // запускаем пять потоков
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }


            void Print()
            {
                waitHandler.WaitOne();  // ожидаем сигнала
                x = 1;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }
                waitHandler.Set();  //  сигнализируем, что waitHandler в сигнальном состоянии
            }
        }
        static void MyMutex()
        {
            int x = 0;
            Mutex mutexObj = new();

            // запускаем пять потоков
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }

            void Print()
            {
                mutexObj.WaitOne();     // приостанавливаем поток до получения мьютекса
                x = 1;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }
                mutexObj.ReleaseMutex();    // освобождаем мьютекс
            }
        }

        static void MySemaphore()
        {
            for(int i = 1; i <= 6; i++)
{
                Reader reader = new Reader(i);
            }
        }



    }
    class Reader
    {
        // создаем семафор
        static Semaphore sem = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;// счетчик чтения

        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = $"Читатель {i}";
            myThread.Start();
        }

        public void Read()
        {
            
            
                sem.WaitOne();  // ожидаем, когда освободиться место

                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(3000);

                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

                sem.Release();  // освобождаем место

                count--;
                Thread.Sleep(7000);
            
        }
    }
}