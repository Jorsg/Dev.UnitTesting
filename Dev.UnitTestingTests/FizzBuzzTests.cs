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
	public class FizzBuzzTests
	{
		

		[Test]
		[TestCase(15,"FizzBuzz")]
		public void GetOutput_InputIsDivisbleBy3And5_ReturnFizzBuzz(int number, string expectedResult) //MethodName_Scenario_ExpectedBehavior
		{
			//Arrange
			var result = FizzBuzz.GetOutput(number);			

			//Asert
			Assert.That(expectedResult, Is.EqualTo(result));
		}

		[Test]
		[TestCase(3, "Fizz")]
		public void GetOutput_InputIsDivisbleBy3Only_ReturnFizz(int number, string expectedResult) //MethodName_Scenario_ExpectedBehavior
		{
			//Arrange
			var result = FizzBuzz.GetOutput(number);

			//Asert
			Assert.That(expectedResult, Is.EqualTo(result));
		}

		[Test]
		[TestCase(5, "Buzz")]
		public void GetOutput_InputIsDivisbleBy5Only_ReturnBuzz(int number, string expectedResult) //MethodName_Scenario_ExpectedBehavior
		{
			//Arrange
			var result = FizzBuzz.GetOutput(number);

			//Asert
			Assert.That(expectedResult, Is.EqualTo(result));
		}

		[Test]
		[TestCase(1, "1")]
		public void GetOutput_InputIsNoDivisbleBy3Or5_ReturnTheSameNumber(int number, string expectedResult) //MethodName_Scenario_ExpectedBehavior
		{
			//Arrange
			var result = FizzBuzz.GetOutput(number);

			//Asert
			Assert.That(expectedResult, Is.EqualTo(result));
		}

	}
}
