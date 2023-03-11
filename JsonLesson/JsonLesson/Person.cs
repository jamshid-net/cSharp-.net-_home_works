using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLesson
{
    class Root
    {
        public List<Person> Person { get; set; } = new();
    }
    class Person
    {
        public int id { get; set; }

        
        public string name { get; set; }
       
        public string email { get; set; }

        public Person()
        {

        }
        public Person(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
           
            this.email = email;

        }

        public void Add(Person person)
        {
           
           
        }

        public void Add(List<Person> list)
        {
            

        }
        public override string ToString()
        {
            return $"id:{id}, name:{name}, email:{email}";
        }
    }
}
