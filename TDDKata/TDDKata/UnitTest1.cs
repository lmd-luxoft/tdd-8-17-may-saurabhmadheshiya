using TDDKataCalc;
using Xunit;

namespace TDDKata
{
    public class UnitTest1
    {
        /*Create a simple String calculator with a method int Add(string numbers)The method can take 0, 1 or 2 numbers,
             and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
            Start with the simplest test case of an empty string and move to 1 and 2 numbers
            Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
            Remember to refactor  after each passing test */
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
        [Fact]
        public void AddStringAndDigitWithCommasAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "abc,1,2";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
