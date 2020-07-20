using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace AwesomeCalculatorTest
{
    [TestFixture]
    public class CalcTest
    {

        [Test]
        public void GetAddition_Input50point10_40point90_Expected91()
        {

            //Arrange
            double firstNumber = 50.10;
            double secondNumber = 40.90;

            double expected = 91.0;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAddition_Input567_876_Expected1443()
        {

            //Arrange
            double firstNumber = 567;
            double secondNumber = 876;

            double expected = 1443.0;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAddition_Input4point200_2point400_Expected6point6()
        {

            //Arrange
            double firstNumber = 4.200;
            double secondNumber = 2.400;

            double expected = 6.6;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetSubtraction_Input50point10_40point90_Expected9point2()
        {

            //Arrange
            double firstNumber = 50.10;
            double secondNumber = 40.90;

            double expected = 9.2;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetSubtraction_Input567_876_ExpectedNegative309()
        {

            //Arrange
            double firstNumber = 567;
            double secondNumber = 876;

            double expected = -309;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetSubtraction_Input45point859_12point654_Expected33point654()
        {

            //Arrange
            double firstNumber = 45.859;
            double secondNumber = 12.654;

            double expected = 33.20;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetMultiplication_Input50point10_40point90_Expected2049point09()
        {

            //Arrange
            double firstNumber = 50.10;
            double secondNumber = 40.90;

            double expected = 2049.09;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetMultiplication_Input567_876_Expected496point69()
        {

            //Arrange
            double firstNumber = 567;
            double secondNumber = 876;

            double expected = 496692.0;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetMultiplication_Input5point859_1point654_Expected9point69()
        {

            //Arrange
            double firstNumber = 5.859;
            double secondNumber = 1.654;

            double expected = 9.69;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetDivision_Input50point10_51_Expected0point98()
        {

            //Arrange
            double firstNumber = 50.10;
            double secondNumber = 51;

            double expected = 0.98;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetDivision_Input55_85_Expected17()
        {

            //Arrange
            double firstNumber = 85;
            double secondNumber = 5;

            double expected = 17;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetDivision_Input12_0_ExpectedPositiveInfinity()
        {

            //Arrange
            double firstNumber = 12;
            double secondNumber = 0;

            double expected = double.PositiveInfinity;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);  
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();
            //Assert
            Assert.AreEqual(expected, actual);
           

        }

        [Test]
        public void GetDivision_Input0_10_Expected0()
        {

            //Arrange
            double firstNumber = 0;
            double secondNumber = 10;

            double expected = 0;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);


        }


    }
}
