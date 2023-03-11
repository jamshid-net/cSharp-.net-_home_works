using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
   class Employee : Person
    {
		private int experience;

		public int ExperienceYear
		{
			get { return experience; }
			set { experience = value; }
		}
		
		public static Employee PrintExperience(Employee employee)
		{
			
			if (employee.experience > 0 && employee.experience <= 2) Console.WriteLine("Junior"); 
			if (employee.experience > 2 && employee.experience <= 4) Console.WriteLine("Middle"); 
			if (employee.experience > 4 && employee.experience <= 6) Console.WriteLine("Senior"); 
			if (employee.experience > 6) Console.WriteLine("lead"); 
			
			return employee;
		}

		
		
		

	}
}
