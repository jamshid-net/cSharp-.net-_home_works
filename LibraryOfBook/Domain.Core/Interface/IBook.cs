using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interface
{
    public interface IBook
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Author { get; set; }



    }
}
