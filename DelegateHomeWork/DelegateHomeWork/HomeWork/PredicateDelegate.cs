using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.HomeWork
{
    static class PredicateDelegate
    {
        public static void Run()
        {
           
           
            MarketCars marketCars = new(new List<Cars>
            {
                new Cars("Bmw",2001,3.0),
                new Cars("Supra",2007,3.5),
                new Cars("Mercedec",2011,2.0),
                new Cars("Honda",2012,1.8),
                new Cars("Toyota",2001,3.2),
                new Cars("Hyundai",2003,1.6),
                new Cars("Kia",2008,2.2),
                new Cars("Ford Mustang",2002,5.5),
                new Cars("Camaro",2004,4.0),
                new Cars("Mitsubishi",2004,3.0),
                new Cars("Nissan",2004,2.5),
                new Cars("Civic",2005,1.5),
                new Cars("skoda",2018,2.3),
                new Cars("Tesla",2020,4.5)  
            });
 
            Predicate<Cars> predicate = car =>
            {
                return car.year>2005 && car.liter>2.2;
                
            };
            marketCars.cars.FindAll(predicate).ForEach(car => Console.WriteLine(car));
            
           
        }

    }

    class Cars
    {

        public Cars(string name, int year, double litr)
        {
            this.name = name;
            this.year = year;
            liter = litr;

        }
        public double liter { get; set; }

        public int year { get; set; }
        public string name { get; set; }


        public override string ToString()
        {
            return $"name:{name}, year:{year}, liter:{liter}";
        }

    }
    class MarketCars
    {

        public List<Cars> cars;

        public MarketCars(List<Cars> cars)
        {
            this.cars = cars;

        }

        public IEnumerator GetEnumerator() => cars.GetEnumerator();


    }

}
