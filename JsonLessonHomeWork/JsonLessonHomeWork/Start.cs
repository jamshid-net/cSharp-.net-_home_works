using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonLessonHomeWork
{
    class Start
    {
        //JObject myOldjson = JObject.Parse(File.ReadAllText((@"..\..\..\mytest.json")));
        
        public void Run()
        {
            Request myRequest = new Request();

            Folder folder = new Folder()
            {

                created = DateTime.Now,
            };


            //Header header = new Header()
            //{

            //};

            Root root = new Root()
            {
                client = "Thunder Client",
                collectionName = "Online shopping",
                dateExported = DateTime.Now,
                version = "2.1",
                folders = new List<Folder>() { folder },


            };
            string obj = JsonConvert.SerializeObject(root, Formatting.Indented);
            if (!File.Exists(@"..\..\..\mytest.json"))
            {
                File.Create(@"..\..\..\mytest.json").Dispose();
                using (StreamWriter writer = new(@"..\..\..\mytest.json"))
                {
                    writer.Write(obj);
                }

            }








            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(File.ReadAllText(@"..\..\..\mytest.json"));
            Console.WriteLine("1.Add Request");
            Console.WriteLine("2.Add Folder");
            Console.WriteLine("3.Add Header");
            Console.Write("Number: ");
            int num = Convert.ToByte(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (num)
                {
                    case 1: myDeserializedClass?.requests.Add(addRequest()); ; flag = false; Console.WriteLine("Qaytib keldi"); ; break;
                  
                    default:
                        break;
                }


            }



          
           

            
           
            string myNewJson = JsonConvert.SerializeObject(myDeserializedClass, Formatting.Indented);

            using (StreamWriter writer1 = new(@"..\..\..\mytest.json"))
            {
                writer1.Write(myNewJson);
            }




        }

        public Request addRequest()
        {
            Request request = new Request()
            {
                modified = DateTime.Now,
                created = DateTime.Now,

            };
            Console.Write("containerId:");
            request.containerId = Console.ReadLine();
            Console.Write("SortNum:");
            request.sortNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Colid:");
            request.colId= Console.ReadLine();
            Console.Write("name: ");
            request.name= Console.ReadLine(); 
            Console.Write("_id: ");
            request._id= Console.ReadLine();
           
            //Console.WriteLine("Do you want add headers?");
            //Console.WriteLine("1.Yes");
            //Console.WriteLine("2.No, back");
            //Console.WriteLine("3.Exit");
            //int num = Convert.ToInt32(Console.ReadLine());
            
            //Header header = new Header();
            //bool flag = false;
            //while (flag)
            //{
            //    request?.headers?.Add(header);
            //    switch (num)
            //    {
            //        case 1:addHeader(ref header); flag = false; break;
            //        case 2: Run(); break;
            //        case 3: Environment.Exit(0); break;

            //        default: ;break;
            //    }

            //}
            return request;
            
            
            
           




        }

        public void addHeader(ref Header head)
        {
            Header header = new Header();
            Console.Write("Name: ");
            header.name = Console.ReadLine();
            Console.Write("Value: ");
            header.value= Console.ReadLine();

            head = header;

        }

    }
}
