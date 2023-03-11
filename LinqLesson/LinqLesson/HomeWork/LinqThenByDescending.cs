using LinqLesson.HomeWork.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson.HomeWork
{
    
    internal class LinqThenByDescending
    {
        public readonly static string PATH = @"D:\ForGitHub\LinqLesson\LinqLesson\HomeWork\Json\users.json";
        public static void Run()
        {
            var users = new List<Users>();
            users = JsonConvert.DeserializeObject<List<Users>>(File.ReadAllText(PATH));

            var UserThenByDes = users.OrderBy(x => x.id).ThenByDescending(x => x.email.Length).ToList();
            Console.WriteLine("sorted ThenByDescending by Method, ThenbyDes:");
            Console.WriteLine();
            UserThenByDes.ForEach(x => Console.WriteLine("id:" + x.id + " email: " + x.email));
            Console.WriteLine();
            Console.WriteLine("Diffrence :");

            Console.WriteLine("ThenBy: ");
            var UserThenby = users.OrderBy(x => x.id).ThenBy(x => x.email).ToList();
            UserThenby.ForEach(x => Console.WriteLine("id:" + x.id + " email: " + x.email));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            var userLinqThenbyDes = (from user in users
                                 orderby
                                 user.id,user.name.Length descending, user.email.Length descending
                                 select user).ToList();
            Console.WriteLine("sorted id and descending email, by Linq syntax: ");
            Console.WriteLine();
            Console.WriteLine();
            userLinqThenbyDes.ForEach(x => Console.WriteLine("id: " + x.id +"  name: "+ x.name + "  |email: " + x.email));

            Console.WriteLine();
            Console.WriteLine("Diffrence. ThenBy: ");
            Console.WriteLine();

            var userLinqThenby = (from user in users
                                  orderby
                                  user.id, user.email.Length 
                                  select user).ToList();
            userLinqThenby.ForEach(x => Console.WriteLine("id: " + x.id + " email: " + x.email));
        }
    }
}
