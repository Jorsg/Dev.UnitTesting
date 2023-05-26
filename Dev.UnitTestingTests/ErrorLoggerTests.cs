using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
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
    public class ErrorLoggerTests
    {
        private UnitTesting.Fundamentals.ErrorLogger _Logger;
        [SetUp]
        public void SetUp()
        {
            _Logger = new UnitTesting.Fundamentals.ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            _Logger.Log("J");

            Assert.That(_Logger.LastError, Is.EqualTo("J"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThorwArgumentNullExceptio(string error)
        {
            Assert.Throws<ArgumentNullException>(() => _Logger.Log(error));
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var id = Guid.Empty;
            _Logger.ErrorLogged += (sender, args) => { id = args; };

            _Logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
