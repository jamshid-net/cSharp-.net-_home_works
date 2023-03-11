using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLessonHomeWork
{
    
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Folder
    {
        public string? containerId { get; set; }
        public int sortNum { get; set; }
        public string? name { get; set; }
        public string? _id { get; set; }
        public DateTime created { get; set; }
    }

    public class Header
    {
        public string? name { get; set; }
        public string? value { get; set; }  

    }

    public class Request
    {
        public string? containerId { get; set; }
        public int sortNum { get; set; }
        public List<Header>? headers { get; set; }
        public string? colId { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
        public string? method { get; set; }
        public DateTime modified { get; set; }
        public DateTime created { get; set; }
        public string? _id { get; set; }
        
    }

    public class Root
    {
        public string client { get; set; }
        public string collectionName { get; set; }
        public DateTime dateExported { get; set; }
        public string version { get; set; }
        public List<Folder> folders { get; set; }
        public List<Request>? requests { get; set; } = new();
    }


}
