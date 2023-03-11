using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XmlLesson
{
    class ForRun
    {

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Read");
            Console.WriteLine("3.Change");
            Console.WriteLine("4.Delete");
            Console.WriteLine("5.Exit");
            Console.WriteLine("--------------------------");

            int num = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (num)
                {
                    case 1:Case1();break;
                        case 2: Case2(); break;
                        case 3:;break;
                        case 4:;break;
                        case 5:;break;

                    default:
                        break;
                }

            }


            

        }


        public void Case1()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo? directoryInfo = new DirectoryInfo(path);
            directoryInfo = directoryInfo?.Parent?.Parent?.Parent;
            
           
            if(!File.Exists(directoryInfo.FullName + @"\MyXml.xml"))
            {
                File.Create(directoryInfo.FullName + @"\MyXml.xml").Dispose();
            }

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age= Convert.ToInt32(Console.ReadLine());
            Person person = new(name, age);
            person.add(person, directoryInfo.FullName + @"\MyXml.xml");

            
            Console.WriteLine("1.Menu");
            Console.WriteLine("2.Exit");
            Console.Write("Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                switch (num)
                {
                    case 1: Run(); break;
                    case 2: Environment.Exit(0);break;
                    default:
                        break;
                }

            }
            
           
          
           


        }
        public void Case2()
        {
            //string path = Directory.GetCurrentDirectory();
            //DirectoryInfo? directoryInfo = new DirectoryInfo(path);
            //directoryInfo = directoryInfo?.Parent?.Parent?.Parent;
            //XmlSerializer xml = new(typeof(List<Person>));
            //XmlDocument doc = new();
            //doc.Load(directoryInfo.FullName + @"\MyXml.xml");
            ////Person[] persons;
            ////XmlNodeList people = doc.SelectNodes("/ROOT/Person");

            ////using(FileStream str = File.OpenRead(directoryInfo.FullName + @"\MyXml.xml"))
            ////{

            ////}

            //XmlNode node = doc.SelectSingleNode("ROOT/Person/name");
            //Console.WriteLine(node.InnerText);

            //dynamic num = 12;
            //Console.WriteLine(typeof(num));

           
        }


    }
}
