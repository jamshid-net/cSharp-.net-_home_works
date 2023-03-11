using LinqLesson.HomeWork.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson.HomeWork
{
    class LinqOrderBy
    {
        // Linq user orederby sort by id 
        public readonly static string PATH = @"D:\ForGitHub\LinqLesson\LinqLesson\HomeWork\Json\users.json";

        public static void SortById()
        {
            
           var users = new List<Users>();
           users=  JsonConvert.DeserializeObject<List<Users>>(File.ReadAllText(PATH));
           
            // sorting with method OrderBy for id
            List<Users>? sortUsersByMethod =users?.OrderBy(x => x.id).ToList();
            foreach (var user in sortUsersByMethod)
            {
                Console.WriteLine("Sorted by method id : "+user.id);
            }

            // sorting with LINQ orderby for name
            var sortedUsers = from user in users
                              orderby user.name
                              select user;

            foreach (var item in sortedUsers)
            {
                Console.WriteLine("Sorted by linq name: "+ item.name);

            }
            
        }



    }
}
