using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace LinqHomeWorks.Uzlinq
{
    class UZLINQ
    {
        static readonly string PATH = @"D:\ForGitHub\LinqHomeWorks\LinqHomeWorks\Uzlinq\C# student data in excel.json";
       
        public static List<StudentRoot> ListStudent()
        {
            List<StudentRoot>? student = JsonConvert.DeserializeObject<List<StudentRoot>>(File.ReadAllText(PATH));
            return student;
        }

        public static void problem1()
        {
            var newStundentList = from student in ListStudent()
                                  where student.Group == 2
                                  select new
                                  {
                                      firstName = student.Firstname, lastName = student.LastName
                                  };
            foreach (var item in newStundentList)
            {
                Console.WriteLine(item.firstName+" "+item.lastName);
            }

        }
        public static void problem2()
        {
           
            var problem2 = from student in ListStudent()
                           where student.Firstname.First() < student.LastName.First()
                           select new
                           {
                               firstName = student.Firstname,
                               lastName = student.LastName
                           };
            foreach (var item in problem2)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }
        }
        public static void problem3()
        {
            var problem3 = from student in ListStudent()
                           where student.Age >= 18 && student.Age <= 24
                           select new
                           {
                               firstName = student.Firstname,
                               lastName = student.LastName,
                               age = student.Age

                           };
            foreach (var item in problem3)
            {
                Console.WriteLine(item.firstName+" "+item.lastName+" "+item.age);
            }
                               

        }
        public static void problem4()
        {
            var problem4 = from student in ListStudent()
                           orderby student.LastName
                           orderby student.Firstname descending
                           select new
                           {
                               firstName = student.Firstname,
                               lastName = student.LastName,
                           };
            foreach (var item in problem4)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }

        }
        public static void problem5()
        {
            string pattern = @"\w+@gmail\.com";

            var problem5 = from student in ListStudent()
                           where Regex.IsMatch(student.Email, pattern)
                           select new
                           {
                               firstName = student.Firstname,
                               lastName = student.LastName,
                               email = student.Email
                           };
            foreach (var item in problem5)
            {
                Console.WriteLine(item.firstName + " " + item.lastName+"  "+item.email);
            }


        }
        public static void problem6()
        {

            string pattern = @"^+3592\d*$";
            string pattern2 = @"^02\d*$";

            var problem6 = from student in ListStudent()
                           where Regex.IsMatch(student?.Phones?.ToString(), pattern)||
                           Regex.IsMatch(student?.Phones?.ToString(),pattern2)
                           select new
                           {
                               firstName = student.Firstname,
                               lastName = student.LastName,
                               phone = student.Phones
                           };
            foreach (var item in problem6)
            {
                Console.WriteLine(item.firstName + " " + item.lastName+"  "+item.phone);
            }
        }
        public static void problem7()
        {
            var problem7 = from student in ListStudent()
                           where student.Grade1 == 6 || student.Grade2 == 6 || student.Grade3 == 6 || student.Grade4 == 6
                           select new
                           {
                               firstName = student.Firstname,
                               lastName = student.LastName, 
                           };
            foreach (var item in problem7)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }
        }
        public static void problem8()
        {
            
            var problem8 = from student in ListStudent()
                            let grades = new[] {student.Grade1, student.Grade2,student.Grade3,student.Grade4 }.Count(x=> x<=3)
                            where grades>=2
                            select new
                            {
                                firstName = student.Firstname,
                                lastName = student.LastName,
                                grade1= student.Grade1,
                                grade2= student.Grade2,
                                grade3= student.Grade3,
                                grade4 = student.Grade4

                            };
            foreach (var item in problem8)
            {
                Console.WriteLine(item);
            }




        }
        public static void problem9()
        {
            string pattern = @"\d*(14|15)$";
            var problem9 = from student in ListStudent()
                           where Regex.IsMatch(student.FN.ToString(), pattern)
                           select new
                           {
                               fn= student.FN,
                               name = student.Firstname
                           };
            foreach (var item in problem9)
            {
                Console.WriteLine(item);
            }
            

        }
        public static void problem10()
        {
            var problem10 = from student in ListStudent()
                            group student by student.Group
                            into studentGroup
                            orderby studentGroup.Key 
                            select new
                            {
                                key = studentGroup.Key,
                                students = studentGroup.OrderBy(x=>x.Firstname).ToList()

                            };
                           
            foreach (var group in problem10)
            {
                Console.WriteLine("group: "+group.key+" : ");
                foreach (var student in group.students)
                {
                    Console.WriteLine("           "+student.Firstname+" "+student.LastName);
                }
               
            }

        }
        public static void problem11()
        {
            Console.WriteLine("1.Mutaxasislik qo'shish");
            Console.WriteLine("2.Talaba qo'shish");
            Console.WriteLine("3.");


        }


    }

    class StudentSpecialty
    {
        public string specialty { get; set; }
        public int fucNum { get; set; }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string specialty { get; set; }
        public int fucNum { get; set; }

    }
    public class StudentRoot
    {
        public int FN { get; set; }

        [JsonProperty("First name")]
        public string Firstname { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }
        public int Grade4 { get; set; }
        public object Phones { get; set; }
    }


}
