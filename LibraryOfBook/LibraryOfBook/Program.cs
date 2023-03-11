using Bogus;
using Domain.Core.Classes;
using Infrastructure.Books;
using Infrastructure.CrudService;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace LibraryOfBook
{
    internal class Program
    {
        static void Main()
        {
            string PathOfbooks = @"D:\ForGitHub\LibraryOfBook\Infrastructure\Books\books.json";
            Faker faker= new Faker();
            CRudUserService cRudUser = new CRudUserService();
            List<Book>? FiveBooks = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(PathOfbooks));

            cRudUser.RemoveUserBook(1,4);


        }
    }
}