using LinqLesson.HomeWork.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson.HomeWork
{

    internal class LinqThenBy
    {
        public readonly static string PATH = @"D:\ForGitHub\LinqLesson\LinqLesson\HomeWork\Json\users.json";
        public static void Run()
        {
            var users = new List<Users>();
            users = JsonConvert.DeserializeObject<List<Users>>(File.ReadAllText(PATH));

            // CustomSorting Setting used
            List<Users> CustomThenByUsers = users.OrderBy(n=> n.name,new CustomComparer()).ToList();

            //first sorting by id then by name lenght 
            List<Users> CustomThenByUsers2 = users.OrderBy(n => n.id).ThenBy(n => n.name.Length).ToList();

            Console.WriteLine("sorted by method with order and Thenby()");
            CustomThenByUsers2.ForEach(x => Console.WriteLine("id: "+x.id+ " |name: "+x.name));


            //Linq sort with Thenby 
           
            var UsersThenby = (from user in users
                              orderby user.id, user.name.Length
                              select user).ToList();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("sorted by Linq syntax it is Thenby");
            UsersThenby.ForEach(x => Console.WriteLine("id: " + x.id + " |name: " + x.name));
                              




        }

    }


    //Custom Setting for use in OrberBy(___,new CustomComperer());
    class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            int xLenght,yLenght;
            if(x==null) xLenght= 0;
            else xLenght = x.Length;
            if(y==null) yLenght= 0;
            else yLenght = y.Length;
            return xLenght - yLenght; 

        }
    }
}
