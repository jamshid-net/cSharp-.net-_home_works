using Bogus;
using Bogus.Bson;
using Newtonsoft.Json;




namespace LinqLesson.HomeWork.Json
{
    class GenerateUsers
    {
        public void Run()
        {
            var faker = new Faker();

            var users = new List<object>();
            Random random = new();
            for (int i = 0; i < 20; i++)
            {
                var user = new
                {
                    id = random.Next(1, 56) + i + 1,
                    name = faker.Name.FullName(),
                    email = faker.Internet.Email(),
                    phone = faker.Phone.PhoneNumber()
                };
                users.Add(user);
            }
            
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);


          
            File.WriteAllText(@"D:\ForGitHub\LinqLesson\LinqLesson\HomeWork\Json\users.json", json);
        }

        public void run2()
        {
            
        }

    }
    class Users
    {
       
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            
    }

    record Adress(int id, string adressLine);
    record Employee(int id, string name);

   
}
