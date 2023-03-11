using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.DelegateTest
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string SmsStatus { get;private set; }
        public  bool SmsSender(string s, Person user)
        {
            user.SmsStatus = s;
            return true;
        }
       
        
    }

    class Message
    {
        public delegate bool SendMessage(string message, Person user);
        public static void Main2() {

            Person mike = new Person()
            {
                Name = "Mike", Email = "Mike444@gmail.com"
                
            };
            Person max = new Person()
            {
                Name = "Max", Email="Max1990@gmail.com"
            };
            SendMessage sendMessage;
            sendMessage = max.SmsSender;
            sendMessage("Hello Mike", mike);
            Console.WriteLine(mike.SmsStatus); // Hello Mike
         
        }

    }
}
