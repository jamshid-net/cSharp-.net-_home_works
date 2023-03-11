using OOP_6.Task_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_3.Classes
{
    class Person : IEmployee

    {
        public void fire()
        {
            throw new NotImplementedException();
        }

        public void hire()
        {
            throw new NotImplementedException();
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _adress;

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string hairColor { get; set; }

        public string eyeColor { get; set; }

        public string setName()
        {
            Console.Write("New name: ");
            Name = Console.ReadLine();
            return _name;
        }
        public string newAdress()
        {
            Console.Write("New adress: ");
            Adress = Console.ReadLine();
            return _name;
        }
        
    }
}
