using Domain.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interface
{
    public interface IUser
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public List<Book> TakenBooks {get; set;}
    }
}
