using System;
using TDDKataCalc;
using Xunit;

namespace TDDKata
{
    public class UnitTest1
    {
        [Fact]
        public void AddNoDigitsAndShouldBeCorrectResult()
        {
            //Arrange
            string digits = "";
            int expected = 0;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddDigitsAndShouldBeCorrectResult()
        {
            //Arrange
            string digits = "1,2,3";
            int expected = 6;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddDigitsWithMultipleCommasAndShouldBeCorrectResult()
        {
            //Arrange
            string digits = "1,,2,,3";
            int expected = 6;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
