using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.HomeWork
{ 
    internal class DelegateGeneric
    {
        public delegate T MyDelegate<T>(List<T> val, string text);

        public static void Run()
        {
            List<string> list = new() {"Book", "Tv", "Phone", "Laptop" , "Computer" };
            MyDelegate<string> myDelegate = FindText;
            string result = myDelegate(list, "book");
            Console.WriteLine(result);
            
        }

        public static string FindText(List<string> val, string text)
        {
            foreach (var item in val)
            {
                if (item.ToLower() == text)
                    return item;
            }
            return "Topilmadi";
    
            
        }


    }
    class smsService
    {
        public delegate void MyDelegate(string message, smsService sms);
        public string user { get; set; }
        public int number { get; set; }

        public string mySmses { get; set; }

        public  void SendMessage(string message, smsService sms)
        {
            sms.mySmses = message;
            Console.WriteLine($"sms sended from: {user}, number:{number} date: {DateTime.Now}");

        }

        public void Social()
        {
            smsService BobsMessage = new smsService();
            smsService MikesMessage = new smsService();
            MikesMessage.number = 999314214;
            MikesMessage.user = "Mike";
            MyDelegate myMessage;
            myMessage = MikesMessage.SendMessage;
            myMessage("Hello", BobsMessage);
            Console.WriteLine(BobsMessage.mySmses);

        }
        

    }



}
