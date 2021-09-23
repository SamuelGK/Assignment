using Assignemnt;
using System;
using Xunit;

namespace TestCalculator.Tests
{
    public class ProgramTests
    {
        [Fact] // Första metoden 
        public void SimpleAddition()
        {

            //Arrange // Talen och svaret

            Double num1 = 9;
            Double num2 = 6;
            Double expected = 15;

            //Act // Addera talen med varandra 
            Double result = Program.Addition(num1, num2);

            //Assert // Svar från progammet
            Assert.Equal(expected, result);

        }

        [Fact] // Andra metoden 

        public void SimpleSubstraction()
        {
            //Arrange 

            Double num1 = 8;
            Double num2 = 4.5;
            Double expected = 3.5;


            //Act
            Double result = Program.Substract(num1, num2);
            //Assert

            Assert.Equal(expected, result);

        }

        [Fact]

        public void SimpleMulti()
        {

            //Arrange

            Double num1 = 3;
            Double num2 = 4;
            Double expected = 12;

            //Act

            Double result = Program.Multi(num1, num2);


            //Assert

            Assert.Equal(expected, result);

        }


        [Fact]

        public void SimpleDivide()

        {
            //Arrange

            Double num1 = 12;
            Double num2 = 4;
            Double expected = 3;

            //Act

            Double result = Program.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, result);
        }
        
    } // end of program test
}
