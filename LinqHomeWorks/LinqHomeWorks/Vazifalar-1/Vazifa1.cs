using Bogus;

namespace LinqHomeWorks.Vazifalar_1
{
    class Vazifa1
    {
        public static Faker faker = new();
        public static void Task1()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                numbers.Add(i);
            }
            var myNewList = (from num in numbers
                             where num % 2 == 0
                             select num).ToList();
            myNewList.ForEach(x => Console.Write(x + " "));

        }
        public static void Task2()
        {
            List<int> numbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers.Add(random.Next(-5, 20));
            }
            var myNewList = (from num in numbers

                             where num > 0 && num <= 11
                             orderby num

                             select num).Distinct().ToList();
            myNewList.ForEach(x => Console.Write(x + " "));

        }
        public static void Task3()
        {
            int[] myarr = new int[20];
            Random random = new Random();
            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = random.Next(1, 20);

            }

            var myAnonim = (from num in myarr
                            where Math.Pow(num, 2) > 20

                            orderby num descending
                            select new
                            {
                                number = num,
                                SqrNo = Math.Pow(num, 2)
                            }).Distinct().ToList();
            foreach (var item in myAnonim)
            {
                Console.WriteLine("{" + $" Number = {item.number}, Sqrno = {item.SqrNo} " + "}");
            }


        }
        public static void Task4()
        {

            int[] myarr = new int[20];

            Random random = new Random();
            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = random.Next(1, 20);
            }
            foreach (var item in myarr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");
            var CountMyArray = from num in myarr
                               group num by num
                               into g
                               select new
                               {
                                   key = g.Key,
                                   count = g.Count()

                               };


            foreach (var item in CountMyArray)
            {
                Console.WriteLine($"{item.key} soni {item.count} marta ");
            }

        }
        public static void Task5()
        {
            string word = faker.Random.Words();
            Console.WriteLine(word);
            Console.WriteLine("-------------------");
            var MyStringCount = from str in word
                                where char.IsLetter(str)
                                group str by str
                                into s
                                select new
                                {
                                    letter = s.Key,
                                    count = s.Count()
                                };

            foreach (var item in MyStringCount)
            {
                Console.WriteLine($"Character {item.letter}: {item.count} times");
            }
        }
        public static void Task6()
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            var DaysOfWeeks = from day in dayWeek
                              select day;
            foreach (var item in DaysOfWeeks)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task7()
        {
            int[] myNums = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var myNumsFrequency = from i in myNums
                                  group i by i
                                  into num
                                  select new
                                  {
                                      number = num.Key,
                                      numberCount = num.Count(),
                                      nC = num.Count() * num.Key

                                  };
            Console.WriteLine("Number Number*Frequency Frequency");
            Console.WriteLine("-----------------------------------");
            foreach (var item in myNumsFrequency)
            {
                Console.WriteLine($"number = {item.number}, num*count = {item.nC}, count = {item.numberCount}");
            }
        }
        public static void Task8()
        {
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            char startChar = 'A';
            char finishChar = 'M';
            var City = from city in cities
                       where city.StartsWith(startChar) && city.EndsWith(finishChar)
                       select city;
            foreach (var item in City)
            {
                Console.WriteLine(item);
            }




        }
        public static void Task9()
        {
            List<int> nums = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                nums.Add(random.Next(1, 700));
            }
            var MyCondition = from i in nums
                              where i > 80
                              select i;
            nums.ForEach(x => { Console.Write(x + " "); });
            Console.WriteLine();
            Console.WriteLine("----------------------");
            foreach (var item in MyCondition)
            {
                Console.Write(item + " ");
            }
        }
        public static void Task10()
        {
            List<int> values = new List<int>();


            Console.Write("Nechta raqam qoshmoqchisiz?: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{i}-raqam: ");
                string? s = Console.ReadLine();
                int num;

                bool flag = int.TryParse(s, out num);
                if (flag)
                {
                    num = Convert.ToInt32(s);
                    values.Add(num);
                }
                else
                {
                    i--;
                }

            }
            Console.Write("endi shartdagi Raqam: ");
            int mynum = Convert.ToInt32(Convert.ToString(Console.ReadLine()));
            var MyResult = from i in values
                           where i > mynum
                           select i;
            Console.WriteLine($"Natija {mynum} dan katta sonlar: ");
            foreach (var item in MyResult)
            {
                Console.WriteLine(item);
            }



        }
        public static void Task11()
        {
            List<int> nums = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                nums.Add(random.Next(1, 30));
            }
            nums.ForEach(i => { Console.Write(i + " "); });
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var MaxNnums = (from i in nums
                            orderby i descending
                            select i).Distinct().Take(n);
            foreach (var item in MaxNnums)
            {
                Console.Write(item + " ");
            }



        }
        public static void Task12()
        {
            string str = "this IS a STRING";
            var Up = from s in str.Split(" ")
                     where s == s.ToUpper()
                     select s;


            foreach (var item in Up)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task13()
        {
            string[] array = { "cat", "dog", "rat" };
            string arrayTostr = string.Join(" ",
                             from str in array
                             select str);

            Console.WriteLine(arrayTostr);

        }
        public static void Task14()
        {


            List<StudentTask14> stundents = new List<StudentTask14>();
            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                StudentTask14 student = new(i, faker.Name.FullName(), random.Next(900, 920));

                stundents.Add(student);

            }
            var sortedPointStundents0 = (from student in stundents
                                         orderby student.point descending
                                         select student).ToList();
            sortedPointStundents0.ForEach(x => Console.WriteLine(x));

            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var sortedPointStundents = (from student in sortedPointStundents0
                                        group student by student.point).Skip(n - 1).Take(1);

            foreach (var student in sortedPointStundents)
            {
                foreach (var item in student)
                {
                    Console.WriteLine(item);
                }
            }



        }
        public static void Task15()
        {

            string[] filenames = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            var FinalGr = from file in filenames
                          group Path.GetExtension(file) by Path.GetExtension(file.ToLower())
                        into ext
                          select new
                          {
                              file = ext.Key,
                              count = ext.Count()
                          };

            foreach (var item in FinalGr)
            {
                Console.WriteLine($"{item.count} File(s) with {item.file} extensions");
            }

        }
        public static void Task16()
        {

            List<string> myFiles = Directory.GetFiles(@"D:\").ToList();

            var average = (from file in myFiles
                           select new FileInfo(file).Length).Average() / (1024 * 1024);

            Console.WriteLine("average files of mb: " + average.ToString("F2") + " mb");


        }
        public static void Task18()
        {

            List<char> myChars = new() { 'm', 'n', 'o', 'p', 'q' };
            myChars.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Char: ");
            char c = Convert.ToChar(Console.ReadLine());
            var rmvChar = from ch in myChars
                          where ch != c
                          select new
                          {
                              myC = ch
                          };

            foreach (var item in rmvChar)
            {
                Console.Write(item.myC + " ");
            }


        }
        public static void Task19()
        {
            List<char> myChars = new() { 'm', 'n', 'o', 'p', 'q' };
            myChars.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Char: ");
            char c = Convert.ToChar(Console.ReadLine());
            myChars.RemoveAll(x => x == c);

        }
        public static void Task20()
        {
            List<char> myChars = new() { 'm', 'n', 'o', 'p', 'q' };
            myChars.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            myChars.RemoveAt(index);
            myChars.ForEach(x => Console.Write(x + " "));
        }
        public static void Task21()
        {
            List<char> myChars = new() { 'm', 'n', 'o', 'p', 'q' };
            myChars.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("nechtasi: ");
            int count = Convert.ToInt32(Console.ReadLine());
            myChars.RemoveRange(index, count);
            myChars.ForEach(x => Console.Write(x + " "));
        }
        public static void Task22()
        {
            string[] arr = { "this", "is", "a", "string" };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("Input the minimum length of the item you want to find: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var arrN = from str in arr
                       where str.Length > n
                       select str;
            foreach (var item in arrN)
            {
                Console.Write(item + " ");
            }
        }
        public static void Task23()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> list = new List<string>() { "Bob", "Martin", "Alex", "Anton", "Nico" };
            var crosJoin = from num in nums
                           from name in list
                           select (num, name);
            foreach (var item in crosJoin)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task24()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> list = new List<string>() { "Bob", "Martin", "Alex", "Anton", "Nico" };
            List<int> n = new List<int>() { 55, 66, 7, 13, 5 };
            var crosJoin = from num in nums
                           from name in list
                           from nn in n
                           select new
                           {
                               num,
                               name,
                               nn
                           };
            foreach (var item in crosJoin)
            {
                Console.WriteLine(item.num + "  " + item.name + "  " + item.nn);
            }
        }
        public static void Task25()
        {
            List<Order> orders = new List<Order>
                {
                    new Order { OrderId = 1, CustomerId = 1, Amount = 100.00M },
                    new Order { OrderId = 2, CustomerId = 2, Amount = 50.00M },
                    new Order { OrderId = 3, CustomerId = 3, Amount = 200.00M }
                };

            List<Customer> customers = new List<Customer>
                {
                    new Customer { CustomerId = 1, Name = "Alice" },
                    new Customer { CustomerId = 2, Name = "Bob" },
                    new Customer { CustomerId = 3, Name = "Charlie" },
                    new Customer { CustomerId = 4, Name = "David" }
                };
            var InnerJoin = from order in orders
                            join customer in customers
                            on order.CustomerId equals customer.CustomerId
                            select new
                            {
                                customer.CustomerId,
                                customer.Name,
                                order.Amount,
                                order.OrderId
                            };
            foreach (var item in InnerJoin)
            {
                Console.WriteLine(item.Name + " | " + item.CustomerId + " | " + item.Amount);
            }

        }
        public static void Task26()
        {
            List<Item> items = new List<Item>
            {
                new Item{item = "butter", itemId= 1,priceId =1},
                new Item{item = "Chocolate", itemId= 2,priceId =2},
                new Item{item = "Biscuit", itemId= 3,priceId =0},
                new Item{item = "honey", itemId= 4,priceId =0},
                new Item{item = "honey", itemId= 5,priceId =5},
                new Item{item = "honey", itemId= 6,priceId =6}

            };

            List<Purchase> purchases = new List<Purchase>
            {
                new Purchase{purchase = 560, id= 1},
                new Purchase{purchase = 760, id= 2},
                new Purchase{purchase = 400, id= 5},
                new Purchase{purchase = 120, id= 6},
            };


            var leftJoin = from good in items
                           join purchase in purchases
                           on good.priceId equals purchase.id
                           into myNewItem
                           from newItem in myNewItem.DefaultIfEmpty()
                           select new
                           {
                               goodId = good.itemId,
                               goodName = good.item,
                               goodPurchase = newItem == null ? 0 : newItem.purchase

                           };




            foreach (var item in leftJoin)
            {
                Console.WriteLine(item.goodId + " " + item.goodName + " " + item.goodPurchase);

            }


        }
        public static void Task27()
        {
            List<Item> items = new List<Item>
            {
                new Item{item = "butter", itemId= 1,priceId =1},
                new Item{item = "Chocolate", itemId= 2,priceId =2},
                new Item{item = "Biscuit", itemId= 3,priceId =0},
                new Item{item = "honey", itemId= 4,priceId =0},
                new Item{item = "honey", itemId= 5,priceId =5},
                new Item{item = "honey", itemId= 6,priceId =6}

            };

            List<Purchase> purchases = new List<Purchase>
            {
                new Purchase{purchase = 560, id= 1},
                new Purchase{purchase = 760, id= 2},
                new Purchase{purchase = 400, id= 5},
                new Purchase{purchase = 120, id= 6},
            };


            var rightJoin = from purchase in purchases
                            join good in items
                            on purchase.id equals good.priceId
                            into myNewItem
                            from newItem in myNewItem.DefaultIfEmpty()
                            select new
                            {
                                goodId = newItem == null ? 0 : newItem.itemId,
                                goodName = newItem == null ? "No Good" : newItem.item,
                                goodPurchase = purchase.purchase
                            };

            foreach (var item in rightJoin)
            {
                Console.WriteLine(item.goodId + " " + item.goodName + " " + item.goodPurchase);
            }

        }
        public static void Task28()
        {
            List<string> cityNames = new List<string> { "ROME", "PARIS", "LONDON", "ZURICH", "NAIROBI", "ABU DHABI", "AMSTERDAM", "NEW DELHI", "CALIFORNIA" };
            var task28 = (from city in cityNames
                          orderby city.Length
                          select city).ThenBy(x=>x);
            foreach (var item in task28)
            {
                Console.WriteLine(item);
            }


        }
        public static void Task29()
        {
            List<string> cityNames = new List<string> { "ROME","LOS ANGLES", "PARIS", "LONDON", "ZURICH", "NAIROBI", "ABU DHABI", "AMSTERDAM", "NEW DELHI", "CALIFORNIA" };
            var groupByName = from city in cityNames
                              group city by city.First()
                              into groupped
                              select groupped;

            foreach (var gr in groupByName)
            {
               
                foreach (var item in gr)
                {
                    Console.Write(item+", ");
                }
                Console.WriteLine();
            }

        }
        public static void Task30()
        {
            List<string> foodItems = new List<string> { "Biscuit", "Honey", "Brade", "Biscuit", "Brade", "Butter", "Honey" };

            var sortedAndRemoveDup = (from food in foodItems 
                                     orderby food ascending 
                                     select food).Distinct();
            foreach (var item in sortedAndRemoveDup)
            {
                Console.WriteLine(item);
            }
        }



























        class Item
        {
            public int itemId { get; set; }
            public string item { get; set; }
            public int priceId { get; set; }

        }

        class Purchase
        {
            public int id { get; set; }
            public int purchase { get; set; }
        }
        record StudentTask14(int id, string name, int point);
        class Order
        {
            public int OrderId { get; set; }
            public int CustomerId { get; set; }
            public decimal Amount { get; set; }
        }

        class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int DepartmentId { get; set; }
        }

        public class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }


    }
}
