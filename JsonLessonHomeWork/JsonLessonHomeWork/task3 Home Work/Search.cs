using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLessonHomeWork.task3_Home_Work
{
     class Search
     {
        public static string UserPath = @"..\..\..\task3 Home Work\users.json";
      //  public static string UserPath = @"D:\ForGitHub\JsonLessonHomeWork\JsonLessonHomeWork\task3 Home Work\users.json";
        public void start(string findKey)
        {
            List<General>? myDeserializedClass = JsonConvert.DeserializeObject<List<General>>(File.ReadAllText(UserPath));

          

            General root = myDeserializedClass.Find(x=> (x.username==findKey || x.email==findKey));
            if(root == null) 
            {
                Console.WriteLine("User is not found");
            }
            else
            {

                Console.WriteLine("User: " + root?.name);
                Console.WriteLine("Geo lat:" + root?.address.geo.lat);
                Console.WriteLine("Geo lng:" + root.address.geo.lng);
                Console.WriteLine("--------Company-------");
                Console.WriteLine("Company name: " + root.company.name);
                Console.WriteLine("CatchPhrase: " + root.company.catchPhrase);
                Console.WriteLine("bs: " + root.company.bs);

            }


            
                


          



        }
    }
}
