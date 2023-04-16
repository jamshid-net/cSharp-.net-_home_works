using Newtonsoft.Json;
using System.Xml.Serialization;

namespace AsyncLesson
{
    internal class Program
    {
        static void Main()
        {
          
            MyMethod();




            Console.ReadKey();
        }

        static async void MyMethod()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            // задача вычисляет квадраты чисел
            Task task = new(() =>
            {
                
                Console.WriteLine("Task: "+Thread.CurrentThread.ManagedThreadId);
                for (int i = 1; i < ++i; i++)
                {
                    if (token.IsCancellationRequested)  // проверяем наличие сигнала отмены задачи
                    {
                        Console.WriteLine("Операция прервана");
                        return;     //  выходим из метода и тем самым завершаем задачу
                    }
                    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
                    Thread.Sleep(200);
                }
            }, token);
            task.Start();
            
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine($"Task Status1: {task.Status}");
            Console.WriteLine($"Task Status2: {task.Status}");
            Thread.Sleep(5000);
            // после задержки по времени отменяем выполнение задачи
            cancelTokenSource.Cancel();
            // ожидаем завершения задачи
          

            //  проверяем статус задачи
            Console.WriteLine($"Task Status3: {task.Status}");
            cancelTokenSource.Dispose(); // освобождаем ресурсы
        }


        static void Faktorial(int n)
        {
            CancellationTokenSource tokenSource = new();
            CancellationToken cancellationToken = tokenSource.Token;
            int r = 1;
            Task task = new(async () =>
            {
                for (int i = 1; i < n; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("Stopped");
                        return;
                    }
                    r *= i;
                    Console.WriteLine(i);
                    Thread.Sleep(1000);



                }
            });
            task.Start();
            Console.WriteLine("y for cancel");
            string? y = Console.ReadLine();
            if (y == "y")
            {
                tokenSource.Cancel();
            }
            Console.Read();

        }

        static void Sender(string id)
        {
            Task.Run(() =>
            {

                Soliq(id).Wait();
                Thread.Sleep(5000);
                Console.WriteLine("HELLO");
            });
            Task.Run(() =>
           {
               IIB(id).Wait();

           });
            //Task[] myTasks = { IIB(id), Soliq(id) };
            //Task.WaitAll(myTasks);

        }

        static async Task<string> IIB(string id)
        {


            Task<string> t1 = new(() =>
            {
                return id;
            });
            t1.Start();
            await t1;
            if (t1.IsCompleted)
                Console.WriteLine("iibga yuborildi");


            return id;

        }
        static async Task<string> Soliq(string id)
        {

            Task<string> t1 = new(() =>
            {
                return id;
            });
            t1.Start();
            await t1;
            if (t1.IsCompleted)
                Console.WriteLine("Soliqga Yuborildi");
            return id;

        }

        public static async Task AsynTask()
        {
            await Task.Delay(2000);
            Task task = Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.Name);

            });
            //await Task.Run(() => Console.WriteLine(Thread.CurrentThread.Name));
            Console.WriteLine("hi");
        }
        static async void MyMethod2()
        {
            var result = await AddAsync(4, 5);
            Console.WriteLine(result);

            ValueTask<int> AddAsync(int a, int b)
            {
                return new ValueTask<int>(a + b);
            }
        }



        async static Task Print2()
        {
            Console.WriteLine("Method print2 is  Started");
            Task task = new Task(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Print2 task opened");

            });
            task.Start();
            Console.WriteLine("middle operation of Print");
            //  await Task.Delay(TimeSpan.FromSeconds(5));
            string myPath2 = @"D:\ForGitHub\AsyncLesson\AsyncLesson\myUsers.xml";
            if (!File.Exists(myPath2))
            {
                File.Create(myPath2).Dispose();
            }

            string path = @"C:\Users\DELL\Downloads\Telegram Desktop\users.json";


            List<Root2>? myDeser = JsonConvert.DeserializeObject<List<Root2>>(File.ReadAllText(path));
            // Console.WriteLine("NAME:" + myDeserializedClass[0].name);
            await Task.Run(() =>
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Root2>));

                using (StreamWriter writer = new(myPath2))
                {
                    xmlSerializer.Serialize(writer, myDeser);
                }

            });

            Console.WriteLine("Method print2 is finished");


        }
    }


}
