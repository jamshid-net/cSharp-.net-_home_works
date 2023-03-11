using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLessonHomeWork
{
    internal class start2
    {
        public void Run()
        {
           
            string req = File.ReadAllText(@"..\..\..\shop.json");
            Root? myNewroot = JsonConvert.DeserializeObject<Root>(req);


            // Request myNewreq = JsonConvert.DeserializeObject<Request>(req);
            //addRequest(myNewroot.requests[0]);
            Header header = new Header();
            header.value = "val";
            header.name = "name";
            if(myNewroot?.requests?[0].headers!=null)
            {
                myNewroot.requests?[0].headers?.Add(header);

            }
            File.WriteAllText(@"..\..\..\mytest.json", JsonConvert.SerializeObject(myNewroot, Formatting.Indented));


            //  Console.WriteLine(myNewroot.requests[0].containerId);


        }

        public void addRequest(Request request)
        {
            {
                string joinStringJson = File.ReadAllText(@"..\..\..\mytest.json");
                Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
                root?.requests?.Add(request);
                if (root?.requests == null)
                {
                    root.requests = new List<Request>() { request};
                }
                File.WriteAllText(@"..\..\..\mytest.json", JsonConvert.SerializeObject(root, Formatting.Indented));
            }
        }


      
    }
}
