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
    public class CalcFinalMutantTest
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
        public void GetMultiplication_Input567_876_Expected496692()
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
        public void GetDivision_Input85_5_Expected17()
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

        [Test]
        public void GetAddition_Input30point10_10point70_Expected40point8()
        {

            //Arrange
            double firstNumber = 30.10;
            double secondNumber = 10.70;

            double expected = 40.8;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAddition_Input335_232_Expected567()
        {

            //Arrange
            double firstNumber = 335;
            double secondNumber = 232;

            double expected = 567.0;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAddition_Input1point100_7point300_Expected8point4()
        {

            //Arrange
            double firstNumber = 1.100;
            double secondNumber = 7.300;

            double expected = 8.4;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetSubtraction_Input60point20_30point50_Expected29point70()
        {

            //Arrange
            double firstNumber = 60.20;
            double secondNumber = 30.50;

            double expected = 29.70;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetSubtraction_Input163point50_976point30_ExpectedNegative812point8()
        {

            //Arrange
            double firstNumber = 163.50;
            double secondNumber = 976.30;

            double expected = -812.8;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetSubtraction_Input35point759_13point654_Expected22point10()
        {

            //Arrange
            double firstNumber = 35.759;
            double secondNumber = 13.654;

            double expected = 22.10;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetMultiplication_Input60point10_50point90_Expected3059point09()
        {

            //Arrange
            double firstNumber = 60.10;
            double secondNumber = 50.90;

            double expected = 3059.09;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetMultiplication_Input667_976_Expected517592()
        {

            //Arrange
            double firstNumber = 667;
            double secondNumber = 776;

            double expected = 517592.0;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetMultiplication_Input6point859_2point654_Expected18point20()
        {

            //Arrange
            double firstNumber = 6.859;
            double secondNumber = 2.654;

            double expected = 18.20;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetDivision_Input60point10_20point2_Expected2point98()
        {

            //Arrange
            double firstNumber = 60.10;
            double secondNumber = 20.2;

            double expected = 2.98;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetDivision_Input75_5_Expected15()
        {

            //Arrange
            double firstNumber = 75;
            double secondNumber = 5;

            double expected = 15;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetDivision_Input0point5_15point30_Expected0point09()
        {

            //Arrange
            double firstNumber = 0.5;
            double secondNumber = 15.30;

            double expected = 0.09;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void GetDivision_Input50point40_4_Expected12point6()
        {

            //Arrange
            double firstNumber = 50.40;
            double secondNumber = 4;

            double expected = 12.6;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void GetMultiplication_Input7_20point5_Expected143point5()
        {

            //Arrange
            double firstNumber = 7;
            double secondNumber = 20.5;

            double expected = 143.5;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetSubtraction_Input66_6Expected60()
        {

            //Arrange
            double firstNumber = 66.45;
            double secondNumber = 6.9;

            double expected = 59.55;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAddition_Input45point33_12point34_Expected57point67()
        {

            //Arrange
            double firstNumber = 45.33;
            double secondNumber = 12.34;

            double expected = 57.67;

            //Act
            Calc c = new Calc();

            c.SetFirstNumber(firstNumber);
            c.SetSecondNumber(secondNumber);

            double actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}
