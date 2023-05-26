using Dev.UnitTesting.Fundamentals;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Dev.UnitTestingTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new UnitTesting.Fundamentals.CustomerController();

            var result = controller.GetCustomer(0);


            //NotFound Objet
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFoud Objet and derivados
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnOK()
        {
            var controller = new UnitTesting.Fundamentals.CustomerController();

            var result = controller.GetCustomer(1);

            //OK Objet
            Assert.That(result, Is.TypeOf<Ok>());
        }

    }
}
