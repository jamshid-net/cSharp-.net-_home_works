using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dars_2
{
    class Account2
    {
        private string _name;
        private string _userName;
        private double _balance;
        private long _accountNumber;
        private string _password;

        private string Password
        {
            get 
            {
                return _password; 
            
            }
            set 
            { 
                
                _password =value;
            }
        }
        private void setPassword()
        {
            Password = Console.ReadLine();

            while(Password.Length<8)
            {
                
                Console.WriteLine("Your password is wrong < 8");
                Password = Console.ReadLine();
                
                
            }
            while(Password.Length>=8)
            {

                bool haveNumberInPassword = false;
                for (int i = 0; i < Password.Length; i++)
                {
                    if (char.IsNumber(Password[i]))
                    {
                        haveNumberInPassword = true; break;
                    }
                }
                while (haveNumberInPassword==false)
                {
                    Console.WriteLine("pls minimum one time use a number");
                    Password = Console.ReadLine();
                }

            }


        }
        public Account2()
        {
            setPassword();
        }
        
        
        
        



      
        

        public void GetPassword()
        {
            Console.WriteLine(_password);
        }
        public string Name
        {
            get { return _name; }
            set 
            {
                string pass = Console.ReadLine();
                if (pass.Equals(Password))
                {
                    char.ToUpper(value[0]);
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong Password!");
                }
            }
        }
        public string UserName { get { return _userName; } set { _userName = value; } }

        public double Balance { get { return _balance; } 
            set
            {
                if(value>0) _balance= value;
                else Console.WriteLine("Balance wrong type");
            } 
        }
       



    }
}
