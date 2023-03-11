using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.HomeWork
{
    static class FuncDelegateHw
    {
        public static void Run()
        {
            List<string> list = new List<string>();
            list.Add("Kamol Sholdiyev");
            list.Add("Asad Akromov");
            list.Add("Mike Tyson");
            list.Add("Elyor Tojidinov");
            list.Add("Rajabov Elyor");
            
            Func<List<string>,List<string>> func = (names) =>
            {
                List<string> Filtered = new List<string>();
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].ToLower().Contains(("Elyor").ToLower()))
                       
                    {
                        
                        Filtered.Add(names[i]);
                    }
                  
                }
                return Filtered;
            };
            List<string> filtered = func(list);//x => x.ToLower().Contains("Elyor".ToLower())
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
            
             


        }


    }
}
