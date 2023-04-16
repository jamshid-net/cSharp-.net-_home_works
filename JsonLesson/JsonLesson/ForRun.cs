using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace JsonLesson
{
    internal class ForRun
    {
        public void Run() 
        {
           

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Change");
            Console.Write("Num:");
            int num = Convert.ToInt32(Console.ReadLine());  

            while(true)
            {
                switch (num)
                {
                    case 1:add();break;
                    case 2:;break;
                    case 3:;break;
                    case 4:; break;
                    default:
                        break;
                }


            }


           
        }

        public void add()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo? dr = new DirectoryInfo(path);
            dr = dr?.Parent?.Parent?.Parent;

            if (!File.Exists(dr.FullName + "/myJson.json"))
            {
                string myContent = "{\r\n  \"Person\": [\r\n    \r\n  ]\r\n}";
                File.Create(dr.FullName + "/myJson.json").Dispose();
                File.WriteAllText(dr.FullName + "/myJson.json", myContent);

            }
            else if(File.ReadAllText(dr.FullName + "/myJson.json").Length < 5)
            {
                string myContent = "{\r\n  \"Person\": [\r\n    \r\n  ]\r\n}";
                File.WriteAllText(dr.FullName + "/myJson.json", myContent);
            }
            Console.Write("Name: ");
            string? name = Console.ReadLine();

            Console.Write("id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("email: ");
            string? email = Console.ReadLine();
            Person people = new Person(id, name, email);
            
          
            string jsonText = File.ReadAllText(dr.FullName + "/myJson.json");
            Root? myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonText);
            myDeserializedClass?.Person.Add(people);

            string myNewJson = JsonConvert.SerializeObject(myDeserializedClass, Formatting.Indented);

           using(StreamWriter writer = File.CreateText(dr.FullName + "/myJson.json"))
            {
                writer.Write(myNewJson);
            }

        }

        public void remove()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo? dr = new DirectoryInfo(path);
            dr = dr?.Parent?.Parent?.Parent;

            string jsonText = File.ReadAllText(dr.FullName + "/myJson.json");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonText);

        }

    }

    class PersonData
    {
        public List<Person> person { get; set; } = new();

    }

}
