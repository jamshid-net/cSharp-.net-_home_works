using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.HomeWork
{
    static class ActionDelegate
    {
        
        public static void Run()
        {

            Action<List<string>>  action = palindrome =>
            {
                List<string> list = new List<string>();
                int count = 0;
                string pal = "";
                Console.Write("List: ");
                foreach (var item in palindrome)
                {
                   
                    if(item ==  Reverse(item))
                    {
                        
                         list.Add(item);
                          count++;
                    }
                    Console.Write(item+" ");
                }
                Console.WriteLine();
                Console.WriteLine($"Ichidagi palindromik sozlar {count}ta: ");
                foreach (var item in list)
                {
                    Console.Write(item+" ");

                }

            };
            string Reverse(string s)
            {
                string satr = null;
                for (int i = 0; i < s.Length; i++)
                {
                    satr = s[i] + satr;
                }
                return satr;
            };
            
            List<string> list = new List<string>() { "arra" ,"salom", "mashina", "azza", "1441", "2002","XAXAXAXAX"};
            action(list);
            






        }
    }
}
