using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 2, 3, 4)]
        [InlineData(2, 0, 1, 3)]
        [InlineData(-2, -2, -2, -6)]
        [InlineData(-5, -3, 8, 0)]

        public void Add_Test(int num1, int num2, int num3, int expected)
        {
            //arrange 
            var c = new Calculator(); 


            //act 
            var actual = c.Add(num1, num2, num3);

            //arrange
            Assert.Equal(expected, actual);
        }
        
        
        
        
        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

    }
}
