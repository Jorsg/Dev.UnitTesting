using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dev.UnitTesting.Mocking
{
	public class EmployeeStore : IEmployeeStorege
	{
		private EmployeeContext _db;

		public EmployeeStore()
		{
			_db = new EmployeeContext();
		}
		public void DeleteEmployee(int id)
		{
			var employee = _db.Employees.Find(id);
			if (employee == null) return;
			_db.Employees.Remove(employee);
			_db.SaveChanges();
		}
	}
}
