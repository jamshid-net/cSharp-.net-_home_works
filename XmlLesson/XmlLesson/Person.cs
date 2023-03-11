using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlLesson
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person()
        {

        }
        public Person(string n, int a)
        {
            name = n;
            age = a;
        }
        public override string ToString()
        {
            return $"Name:{name}, age:{age}";
        }

        public void add(Person person, string path)
        {
            XmlDocument doc = new();
            doc.Load(path);
            XmlNode ROOT = doc.SelectSingleNode("/ROOT");
            XmlNode PERSON = doc.CreateElement("Person");
            XmlNode name = doc.CreateElement("name");
            XmlNode age = doc.CreateElement("age");
            name.InnerText = person.name;
            age.InnerText = person.age.ToString();

            PERSON.AppendChild(name);
            PERSON.AppendChild(age);
            ROOT.AppendChild(PERSON);
            doc.Save(path);


        }

        public void Read(Stream stream)
        {
            

        }




    }
}
