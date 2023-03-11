using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using LinqLesson.HomeWork.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LinqLesson.HomeWork
{
    internal class LinqOrderByDescending
    {
        public readonly static string PATH = @"D:\ForGitHub\LinqLesson\LinqLesson\HomeWork\Json\users.json";

        // orderby Descending 

        public static void Run()
        {
            var users = new List<Users>();
            users = JsonConvert.DeserializeObject<List<Users>>(File.ReadAllText(PATH));
            //Descending by Method for id

            Console.WriteLine("Descending sort By method for id");
            var desUser = users?.OrderByDescending(x => x.id).ToList();
            desUser?.ForEach(x => Console.WriteLine("id: " + x.id));

            //Descending by Linq syntax for Name

            var desLinqUser = (from user in users
                              orderby user.name descending
                              select user).ToList();
            Console.WriteLine("Descending sort By Linq for name");
            desLinqUser.ForEach(x => Console.WriteLine("Name: " + x.name));

           




        }

       
    }
}
