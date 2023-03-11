using System.Xml.Linq;

namespace OOP_dars_2
{
    class Account
    {
        


        public static int Persons()
        {
            return count;
        }
        private long _AccountNumber;
        private string _Name;
        private string _LastName;
        private double _Balance;
        private static int count;
       
        public long AccountNumber { get { return _AccountNumber; } set { _AccountNumber = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string LastName { get { return _LastName; } set { _LastName = value; } }
        public double Balance { get { return _Balance; } set { if (value >= 0) _Balance = value; else Console.WriteLine("Balance format is wrong!"); } }

        public Account() : this("none")
        {

            count++;
        }
        public Account(string name) : this(name, "none") 
        { }
        public Account(string name="none", string lastName = "none"):this(name, lastName, 0)
        { }
        public Account(string name, string lastName, long AccNum):this(name, lastName, AccNum,0)
        { }
        public Account(string name, string lastName, long AccNum, double balance)
        { 
            this.Name = name;
            this.LastName = lastName;
            this.Balance = balance;
            this.AccountNumber = AccNum;

        }


        public void Print()
        {
            Console.WriteLine("Name: "+_Name);
            Console.WriteLine("Last name: "+_LastName);
            Console.WriteLine("Account Number: "+_AccountNumber);
            Console.WriteLine("Balance: "+_Balance+" $");
            
        }

    }
    

}
