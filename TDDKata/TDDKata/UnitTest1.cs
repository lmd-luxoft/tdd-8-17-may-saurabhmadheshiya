using System;
using TDDKataCalc;
using Xunit;

namespace TDDKata
{
    public class UnitTest1
    {
        [Fact]
        public void AddBlankAndCalcShouldReturnZero()
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
        public void AddNullAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = null;
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddCorrectDigitsAndCalcShouldReturnCorrectResult()
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
        public void AddMultipleCommasCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "1,,2,,3";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddStringAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "ss";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddCommaSeparatedStringAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "s,s";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddOtherThanCommasAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "1@";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
