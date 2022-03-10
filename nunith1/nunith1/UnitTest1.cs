using NUnit.Framework;
using CalcLibrary;
using System;

namespace UnitTests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator simpleCalculator;

        [SetUp]
        public void Setup()
        {
            simpleCalculator = new SimpleCalculator();
        }

        [Test]
        [TestCase(1, 2, 3)]
        public void Addition_WhenCalled_ReturnsSumOfArguments(double arg1, double arg2, double expectedResult)
        {
            var result = simpleCalculator.Addition(arg1, arg2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(2, 1, 1)]
        [TestCase(1, 1, 0)]
        public void Subtraction_WhenCalled_ReturnsDifferenceOfArguments(double arg1, double arg2, double expectedResult)
        {
            var result = simpleCalculator.Subtraction(arg1, arg2);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Multiplication_WhenCalled_ReturnsMultiplicationOfArguments(double arg1, double arg2, double expectedResult)
        {
            var result = simpleCalculator.Multiplication(arg1, arg2);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(6, 3, 2)]
        [TestCase(1, 0, 0)]
        public void Division_WhenCalled_ReturnsDivisionOfArguments(double arg1, double arg2, double expectedResult)
        {
            try
            {
                var result = simpleCalculator.Division(arg1, arg2);

                Assert.AreEqual(expectedResult, result);
            }
            catch (ArgumentException)
            {
                Assert.Fail("Division by zero");
            }
        }

        /*[Test]
        public void Division_InvalidError_ThrowArgumentException()
        {
            Assert.That(() => simpleCalculator.Division(1, 0), Throws.ArgumentException);
        }*/

        [Test]
        public void TestAddAndClear()
        {
            var result = simpleCalculator.Addition(1, 2);

            Assert.AreEqual(3, result);

            simpleCalculator.AllClear();

            Assert.AreEqual(0, simpleCalculator.GetResult);
        }
    }
}





