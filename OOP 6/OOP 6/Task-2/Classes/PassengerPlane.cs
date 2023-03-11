using OOP_6.Task_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_2.Classes
{
    class PassengerPlane : Aircraft
    {
		private int _pessenger;

		public int PessengerCount
		{
			get { return _pessenger; }
			set { _pessenger = value; }
		}

	}
}
