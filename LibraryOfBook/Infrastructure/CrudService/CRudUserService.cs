using Application.Interface;
using Domain.Core.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CrudService
{
    public class CRudUserService : ICrudUserService
    {
        private static readonly string PATH = @"D:\ForGitHub\LibraryOfBook\Infrastructure\Users\User.json";
        public CRudUserService()
        {

        }
        public void AddUserBook(Book book, int UserId)
        {
            var FindUser = GetUser(UserId);
            FindUser.TakenBooks.Add(book);
            UpdateUser(FindUser);
        }

        public void CreateUser(User user)
        {
            
            var allUser = GetUsers()?.ToList();
            user.Id = allUser.Last().Id + 1;
            allUser?.Add(user);
            SaveUser(allUser);
            
        }

        public void DeleteUser(int id)
        {
            var allUser = GetUsers().ToList();
            var indexUser = allUser.FindIndex(x=> x.Id == id);
            if (indexUser == -1)
                throw new ArgumentException("User not found");
            allUser.RemoveAt(indexUser);
            SaveUser(allUser);

                          

           
        }

        public User? GetUser(int? id)
        {
           return  GetUsers()?.ToList()?.Find(x=> x.Id == id);

        }

        public IEnumerable<Book> GetUserBook(int UserId)
        {
           return GetUsers().ToList().Find(x=> x.Id==UserId).TakenBooks;
           
        }

        public IEnumerable<User>? GetUsers()
        {
            if (!File.Exists(PATH))
                return new List<User>();
            var json = File.ReadAllText(PATH);
                return JsonConvert.DeserializeObject<IEnumerable<User>>(json);
        }

        public void RemoveUserBook(int bookId, int UserId)
        {
            var FindUser = GetUser(UserId);
            var FindBookIndex = FindUser.TakenBooks.FindIndex(x=> x.Id == bookId);
            if (FindBookIndex == -1)
                throw new ArgumentException("book not found");
            FindUser.TakenBooks.RemoveAt(FindBookIndex);
            UpdateUser(FindUser);
        }

        public void SaveUser(IEnumerable<User>? users)
        {
           

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(PATH, json);
        }

        public void UpdateUser(User user)
        {
            var AllUser = GetUsers().ToList();
            int index = AllUser.FindIndex(x=> x.Id == user.Id);
            if (index == -1)
                throw new ArgumentException("user not found");
            AllUser[index] = user;
            SaveUser(AllUser);
           
        }

        public void UpdateUserBook(Book book, int UserId)
        {
           var User = GetUser(UserId);
            var FindBookIndex = User.TakenBooks.FindIndex(x=> x.Id == book.Id);
            if (FindBookIndex != -1) throw new ArgumentException("book not found");
            User.TakenBooks[FindBookIndex] = book;
            UpdateUser(User);
        }

       
        
    }
}
