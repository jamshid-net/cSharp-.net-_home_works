using Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Classes
{
    public class Book : IBook
    {
        public string? Title { get ; set; }
        public int Id { get ; set; }
        public string? Author { get; set; }
        

    }
}
