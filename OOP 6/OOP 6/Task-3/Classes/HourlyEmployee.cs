using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_3.Classes
{
    internal class HourlyEmployee
    {
		private int _hourlyRate;

		public int HourlyRate
		{
			get { return _hourlyRate; }
			set { _hourlyRate = value; }
		}
		private int _jobID;

		public int jobID
		{
			get { return _jobID; }
			set { _jobID = value; }
		}

		public int setRate()
		{
			Console.Write("Set rate: ");
			HourlyRate = Convert.ToInt32(Console.ReadLine());
			return _hourlyRate;
		}



	}
}
