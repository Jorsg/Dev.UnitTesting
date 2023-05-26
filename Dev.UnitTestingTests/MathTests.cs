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
    public class MathTests
    {
        private UnitTesting.Fundamentals.Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new UnitTesting.Fundamentals.Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArgument()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumersUpTolimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EqualTo(new[] {1,3,5}));
        }
    }
}
