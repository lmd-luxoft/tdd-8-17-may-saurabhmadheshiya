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
        [Fact]
        public void AddStringAndDigitOnlyAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "abc12";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddMaxDigitAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = int.MaxValue + 1.ToString();
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }

        /*Allow the Add method to handle new lines between numbers (instead of commas)
            •the following input is ok:  “1\n2,3”  (will equal 6)
            •the following input is NOT ok:  “1,\n”*/
        [Fact]        
        public void AddNewLineWithCommasAndCalcShouldReturnCorrectResult()
        {
            //Arrange
            string digits = "1\n2,3";
            int expected = 6;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddNewLineInEndAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "1,\n";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddStringNewLineAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "A\n";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddNewLineInStartAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "\n1,2";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddOnlyNewLineAndCalcShouldReturnMinusOne()
        {
            //Arrange
            string digits = "\n";
            int expected = -1;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
        /*Support different delimiters
            to change a delimiter, the beginning of the string will contain a separate line that looks like this:  
            “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ 
            the first line is optional – all existing scenarios should still be supported*/
        [Fact]
        public void AddDifferentDelimitersNewLineAndCalcShouldReturnCorrectResult()
        {
            //Arrange
            string digits = "//;\n1;2";
            int expected = 3;
            var result = new Calc();

            //Act
            var actual = result.Add(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
