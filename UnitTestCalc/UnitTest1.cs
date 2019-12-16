using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calcClass;

namespace UnitTestCalc
{
    [TestClass]
    public class UnitTest1
    {

        // Add
        [TestMethod]
        public void Addition()
        {
            CalcMethods testMethod = new CalcMethods();

            // Arrange
            decimal expected = 6;
            decimal actual;

            // 2 act
            actual = testMethod.Add(4,2);

            // 3 assert
            Assert.AreEqual(expected, actual);
        }

        //Subtract
        [TestMethod]
        public void Subtraction()
        {
            CalcMethods testMethod = new CalcMethods();

            // Arrange
            decimal expected = 2;
            decimal actual;

            // 2 act
            actual = testMethod.Subtract(4, 2);

            // 3 assert
            Assert.AreEqual(expected, actual);
        }

        // Multiply
        [TestMethod]
        public void Multiplication()
        {
            CalcMethods testMethod = new CalcMethods();

            // Arrange
            decimal expected = 8;
            decimal actual;

            // 2 act
            actual = testMethod.Multiply(4, 2);

            // 3 assert
            Assert.AreEqual(expected, actual);
        }

        // Divide
        [TestMethod]
        public void Division()
        {
            CalcMethods testMethod = new CalcMethods();

            // Arrange
            decimal expected = 2;
            decimal actual;

            // 2 act
            actual = testMethod.Divide(4, 2);

            // 3 assert
            Assert.AreEqual(expected, actual);
        }

        // Modulus
        [TestMethod]
        public void Mod()
        {
            CalcMethods testMethod = new CalcMethods();

            // Arrange
            decimal expected = 1;
            decimal actual;

            // 2 act
            actual = testMethod.Modulus(5, 2);

            // 3 assert
            Assert.AreEqual(expected, actual);
        }

        // Power
        [TestMethod]
        public void ToPower()
        {
            CalcMethods testMethod = new CalcMethods();

            // Arrange
            decimal expected = 16;
            decimal actual;

            // 2 act
            actual = testMethod.Power(2, 4);
            // 3 assert
            Assert.AreEqual(expected, actual);
        }
    }
}
