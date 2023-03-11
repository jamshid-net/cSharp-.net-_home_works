using Delegate.DelegateTest;
using System.Security.Cryptography.X509Certificates;

namespace Delegate
{
    
    internal class Program
    {
       
       static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add((new Random()).Next(100));
                Console.WriteLine(list[i]);
            }
            DelegateList.Delegat del;
            //DelegateList d = new();
            
            del = DelegateList.GetValues;
         //   var tuple = del(list);
            Console.WriteLine("Min va Max: " + DelegateList.GetValues(list));

          //  Message.Main2();


           // MyclassDelegate.run();

            //myGenericDelegat f = new();
            //f.Run();

            //Mrrr r = new("11", 4) { 
            //    name = "hwll", age = 1
            //};





        }

    }
    
    
   
}