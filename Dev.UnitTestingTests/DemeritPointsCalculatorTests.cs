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
	public class DemeritPointsCalculatorTests
	{
		private UnitTesting.Fundamentals.DemeritPointsCalculator _pointsCalculator;

		[SetUp]
		public void SetUp()
		{
			_pointsCalculator = new UnitTesting.Fundamentals.DemeritPointsCalculator();
		}

		[Test]
		[TestCase(0, 0)]
		[TestCase(64, 0)]
		[TestCase(65, 0)]
		[TestCase(66, 0)]
		[TestCase(70, 1)]
		[TestCase(75, 2)]
		public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoint(int speed, int expectedResult)
		{
			var result = _pointsCalculator.CalculateDemeritPoints(speed);

			Assert.That(result, Is.EqualTo(expectedResult));
        }

		[Test]
		[TestCase(-1)]
		[TestCase(301)]
		public void CalculateDemeritPoumts_SpeedIsNegative_ThorwArgumentOutOfRangeException(int speed)
		{
			Assert.That(() => _pointsCalculator.CalculateDemeritPoints(speed),
				Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
		}
		
	}
}
