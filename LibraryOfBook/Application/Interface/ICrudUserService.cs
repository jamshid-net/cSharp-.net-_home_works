using Domain.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICrudUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int? id);
        void CreateUser(User user); 
        void UpdateUser(User user);
        void DeleteUser(int id);
        IEnumerable<Book> GetUserBook(int UserId);   
        void AddUserBook(Book book, int UserId);
        void RemoveUserBook(int bookId, int UserId);
        void UpdateUserBook(Book book, int UserId);
        void SaveUser(IEnumerable<User>? users);
        

    }
}
