using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(2, 0, 1, 3)]
        [InlineData(-2, -2, -2, -6)]
        [InlineData(-5, -3, 8, 0)]

       
        
        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator();
            

            //Act
            var actual = calculator.Add(num1, num2, num3);
            
            
            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3,  -1)] 
        [InlineData(0, 0,  0)]
        [InlineData(1, 2,  -1)]
        [InlineData(2, 0,  2)]
        [InlineData(-2, -2, 0)]
        [InlineData(-5, -3, -2)]
        
        public void SubtractTest(int num1, int numb2, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(num1, numb2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, 6)] 
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 0, 0)]
        [InlineData(-2, -2, 4)]
        [InlineData(-5, -3, 15)]
        
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, 0)] 
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 0)]
        [InlineData(2, 0, 0)]
        [InlineData(-2, -2, 1)]
        [InlineData(-5, -3, 1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
