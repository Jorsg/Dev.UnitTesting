using Dev.UnitTesting.Mocking;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Dev.UnitTestingTests.Moking
{
	[TestFixture]
	public class EmployeeControllerTests
	{
		private Mock<IEmployeeStorege> _employeeStorege;
		private EmployeeStoreController _employeeController;

		[SetUp]
		public void SetUp()
		{
			_employeeStorege = new Mock<IEmployeeStorege>();
			_employeeController = new EmployeeStoreController(_employeeStorege.Object);
		}


		[Test]
		public void DeleteEmployee_WhenCalled_DeleteEmployeeFromDb()
		{
			int id = 1;
			_employeeController.DeleteEmployee(id);
			_employeeStorege.Verify(c => c.DeleteEmployee(id));
		}
	}
}
