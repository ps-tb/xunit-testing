using System;
using UnitTesting.Math;
using Xunit;

namespace UnitTesting.Tests.Math
{
    public class TestAddition
    {
        [Fact]
        public void OneAddedToOneIsTwo()
        {
            // arrange
            var one = 1;
            var addition = new Addition();

            // act
            var result = addition.AddTwoNumbers(one, one);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void OneIsNonZeroPositiveAndOneAddedToOneIsTwo()
        {
            // arrange
            var one = 1;
            var addition = new Addition();

            // act
            var result = addition.AddTwoNonZeroPositiveIntegers(one, one);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void NegativeOneAddedToOneThrowsException()
        {
            // arrange
            var one = 1;
            var addition = new Addition();

            // act
            Assert.Throws<ArgumentOutOfRangeException>(() => addition.AddTwoNonZeroPositiveIntegers(-1, 1));
        }
    }
}