using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.UnitTesting.Mocking
{
	public class EmployeeStoreController
	{
		private readonly IEmployeeStorege _employee;

		public EmployeeStoreController(IEmployeeStorege employee)
		{
			_employee = employee;
		}

		public ActionResult DeleteEmployee(int id)
		{
			_employee.DeleteEmployee(id);
			return RedirectToAction("Employees");
		}

		private ActionResult RedirectToAction(string employees)
		{
			return new RedirectResult();
		}
	}

	public class ActionResult { }

	public class RedirectResult : ActionResult { }

	public class EmployeeContext
	{
		public DbSet<Employee> Employees { get; set; }

		public void SaveChanges()
		{
		}
	}

	public class Employee
	{
	}
}
