using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace JsonLessonHomeWork.Task1_HomeWork
{


    
   public class Employe
    {
       
        public string EmployeName { get; set;}
        public string DepartamentName { get; set; }

        
    }
    [Serializable]
    public class Root
    {
        public List<Employe> EmployeList { get; set; } = new List<Employe>();
    }
    class ForRun
    {
        static string FolderPath = @"..\..\..\Task1 HomeWork\";
        
        public void Run()
        {
            Employe employe = new Employe();
            employe.EmployeName = "Mike";
            employe.DepartamentName = "Microsoft";
            Employe employe2 = new Employe();
            employe2.EmployeName = "Bob";
            employe2.DepartamentName = "Amazon";
            Root root = new Root();
            root.EmployeList.Add(employe);
            root.EmployeList.Add(employe2);


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Root));
            
            BinaryFormatter binaryFormatter= new BinaryFormatter();

            using (FileStream stream = new(FolderPath + "person.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(stream,employe);
            }

            string newJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            using(StreamWriter writer = new(FolderPath + @"person.json"))
            {
                if(!File.Exists(FolderPath + @"person.json"))
                {
                    File.Create(FolderPath + @"person.json").Dispose();
                }
                writer.Write(newJson);
            }

            using (FileStream stream = new(FolderPath + @"person.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(stream, root);

            }



        }



    }
}
