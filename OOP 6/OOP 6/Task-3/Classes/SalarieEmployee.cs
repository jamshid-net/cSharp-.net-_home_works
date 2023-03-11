using OOP_6.Task_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_3.Classes
{
    class SalarieEmployee : Person , IOffice
    {
		private double _weeklyPay;

		public double weeklyPay
		{
			get { return _weeklyPay; }
			set { _weeklyPay = value; }
		}

        public int getNumber()
        {
            throw new NotImplementedException();
        }

        public int getOccupant()
        {
            throw new NotImplementedException();
        }

        public void moveOffice()
        {
            setNumber();
            getNumber();
            setOccupant();
            getOccupant();

        }

        public int setNumber()
        {
            throw new NotImplementedException();
        }

        public int setOccupant()
        {
            throw new NotImplementedException();
        }
    }
}
