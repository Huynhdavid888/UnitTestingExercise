using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();
            //Act
            var actual = unitTestMethod.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15,8,7)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();
            //Act
            var actual = unitTestMethod.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();
            //Act
            var actual = unitTestMethod.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,2,10)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();
            //Act
            var actual = unitTestMethod.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAdd()
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();
            //Act
            var actual = unitTestMethod.Add(3, 5, 6);
            //Assert
            Assert.Equal(14, actual);
        }

        [Fact]
        public void CanMultiply()
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();
            //Act
            var actual = unitTestMethod.Multiply(2, 9);
            //Assert
            Assert.Equal(18, actual);
        }

    }

    internal class UnitTestMethods
    {
        public UnitTestMethods()
        {
        }

        internal object Add(int num1, int num2, int num3)
        {
            throw new NotImplementedException();
        }

        internal object Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        internal object Multiply(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        internal object Subtract(int minuend, int subtrhend)
        {
            throw new NotImplementedException();
        }
    }
}
