using Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Classes
{
    public class User : IUser
    {
        public string FullName { get ; set ; }
        public int Id { get ; set ; }
        public List<Book> TakenBooks { get;set;}
    }
}
