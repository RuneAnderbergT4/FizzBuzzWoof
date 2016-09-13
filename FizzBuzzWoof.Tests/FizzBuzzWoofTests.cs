using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzWoof.Tests
{
    [TestClass]
    public class FizzBuzzWoofTests
    {
        [TestMethod]
        public void ShouldReturnItselfIfItPassesAllOtherRules()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(1);

            // Assert
            Assert.AreEqual("1", ret);
        }

        [TestMethod]
        public void ShouldReturnFizzForInputDivisibleBy3()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(6);

            // Assert
            Assert.AreEqual("Fizz", ret);
        }

        [TestMethod]
        public void ShouldReturnBuzzForInputDivisibleBy5()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(10);

            // Assert
            Assert.AreEqual("Buzz", ret);
        }

        [TestMethod]
        public void ShouldReturnWoofForInputDivisibleBy7()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(14);

            // Assert
            Assert.AreEqual("Woof", ret);
        }

        [TestMethod]
        public void ShouldReturnFizzForInputContaining3()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(32);

            // Assert
            Assert.AreEqual("Fizz", ret);
        }

        [TestMethod]
        public void ShouldReturnBuzzForInputContaining5()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(52);

            // Assert
            Assert.AreEqual("Buzz", ret);
        }

        [TestMethod]
        public void ShouldReturnWoofForInputContaining7()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(74);

            // Assert
            Assert.AreEqual("Woof", ret);
        }

        [TestMethod]
        public void ShouldReturnFizzFizzForInput3()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(3);

            // Assert
            Assert.AreEqual("Fizz Fizz", ret);
        }

        [TestMethod]
        public void ShouldReturnBuzzBuzzForInput5()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(5);

            // Assert
            Assert.AreEqual("Buzz Buzz", ret);
        }

        [TestMethod]
        public void ShouldReturnWoofWoofForInput7()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(7);

            // Assert
            Assert.AreEqual("Woof Woof", ret);
        }

        [TestMethod]
        public void ShouldReturnFizzFizzFizzForInput33()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(33);

            // Assert
            Assert.AreEqual("Fizz Fizz Fizz", ret);
        }

        [TestMethod]
        public void ShouldReturnBuzzBuzzBuzzForInput55()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(55);

            // Assert
            Assert.AreEqual("Buzz Buzz Buzz", ret);
        }

        [TestMethod]
        public void ShouldReturnWoofWoofWoofForInput77()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(77);

            // Assert
            Assert.AreEqual("Woof Woof Woof", ret);
        }

        [TestMethod]
        public void ShouldReturnFizzBuzzWoofForInput210()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(210);

            // Assert
            Assert.AreEqual("Fizz Buzz Woof", ret);
        }

        [TestMethod]
        public void ShouldReturnFizzBuzzBuzzWoofForInput105()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(105);

            // Assert
            Assert.AreEqual("Fizz Buzz Buzz Woof", ret);
        }

        [TestMethod]
        public void ShouldReturnFizzFizzBuzzBuzzBuzzWoofForInput3535()
        {
            // Arrange
            var fizzBuzzWoof = new FizzBuzzWoof();

            // Act
            var ret = fizzBuzzWoof.Convert(3535);

            // Assert
            Assert.AreEqual("Fizz Fizz Buzz Buzz Buzz Woof", ret);
        }
    }
}
