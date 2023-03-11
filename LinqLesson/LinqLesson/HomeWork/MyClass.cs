using Bogus;
using LinqLesson.HomeWork.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson.HomeWork
{
    class MyClass
    {

        static Faker faker1 = new Faker();

        public static void Run2()
        {


        }
        public static void Run()
        {
            List<Employee> employees = new ();
            for (int i = 0; i < 12; i++)
            {
                employees.Add(new Employee(i + 1, faker1.Name.FirstName()));
            }
          //  employees.ForEach(e => Console.WriteLine(e.name));


            List<Adress> adress = new();
            for (int i = 0; i < 10; i++)
            {
                adress.Add(new Adress(i + 1, faker1.Address.City()));
            }

            var joinEmpAddres = employees.Join(adress,
            x => x.id,
            a => a.id,
            (x, a) => new
            {
             name = x.name,
             adress = a.adressLine
               
            }).ToList();

            var LinqJoin = from emp in employees
                           join adr in adress
                           on emp.id equals adr.id
                           select new
                           {
                               Name = emp.name,
                               Adress = adr.adressLine
                                
                           };


                          

            
            
            joinEmpAddres.ForEach(x => Console.WriteLine($"adress: {x.adress}, name:{x.name}"));


        }
        
    }
}
