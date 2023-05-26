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
    public class HtmlFormatterTests
    {
        [Test]
        public void FormattAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatt = new UnitTesting.Fundamentals.HtmlFormatter();// MethodName_Scenario_ExpectedBehavior

            var result = formatt.FormatAsBold("abc");
            // Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            //More general                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            //Assert.That(result, Does.StartWith("<strong>"));
        }
    }
}
