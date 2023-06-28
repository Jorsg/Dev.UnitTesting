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
	public class StackTests
	{
		[Test] public void Push_ArgIsNull_ThrowArgNullException()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
		}

		[Test]
		public void Push_ValidArg_AddTheObjectToTheStack()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			stack.Push("z");
			Assert.That(stack.Count, Is.EqualTo(1));
		}

		[Test]
		public void Push_Count_EmptyStack_ReturnZero()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();
			
			Assert.That(stack.Count, Is.EqualTo(0));
		}

		[Test]
		public void Pop_EmptyStack_ThrowInvalidOperationException()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
		}

		[Test]
		public void Pop_StackWithAFewObjects_ReturnObjecOnTheTop()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");
			//Act
			var result = stack.Pop();
			//Assert
			Assert.That(result, Is.EqualTo("c"));

		}

		[Test]
		public void Pop_StackWithAFewObjects_RemoveObjecOnTheTop()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");
			//Act
			 stack.Pop();
			//Assert
			Assert.That(stack.Count, Is.EqualTo(2));
		}

		[Test]
		public void Peek_EmptyStack_ThrowInvalidOperation()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
		}

		[Test]
		public void Peek_StackWithObject_ReturnObjectOnTopTheStack()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");

			//Act
			var result = stack.Peek();

			//Assert
			Assert.That(result, Is.EqualTo("c"));
		}

		[Test]
		public void Peek_StackWithObject_DoesNotRemoveTheObjectOnTopOfTheStack()
		{
			var stack = new UnitTesting.Fundamentals.Stack<string>();

			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");
			//Act
			stack.Peek();
			//Assert
			Assert.That(stack.Count, Is.EqualTo(3));
		}

	}
}
