using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unit_Tasks;
//using Unit_T;

namespace UnitTestProject1
{
    [TestClass]
    public class LatinAlphabetStringTests
    {
        [TestMethod]
        public void GetLatinAlphabetString_ValidInput_ReturnsCorrectString()
        {
            // Arrange
            int n = 3;
            string expectedResult = "ABC";

            // Act
            string actualResult = LatinAlphabetString.GetLatinAlphabetString(n);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetLatinAlphabetString_InvalidInputLessThanOne_ThrowsArgumentException()
        {
            // Arrange
            int n = 0;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => LatinAlphabetString.GetLatinAlphabetString(n));
        }

        [TestMethod]
        public void GetLatinAlphabetString_InvalidInputGreaterThanTwentySix_ThrowsArgumentException()
        {
            // Arrange
            int n = 27;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => LatinAlphabetString.GetLatinAlphabetString(n));
        }
    }

    [TestClass]
    public class QuadraticEquationSolverTests
    {
        [TestMethod]
        public void SolveQuadraticEquation_()
        {



        }

            [TestMethod]
        public void SolveQuadraticEquation_ValidInputWithRealRoots_ReturnsCorrectRoots()
        {
            // Arrange
            double a = 1, b = 5, c = 6;
            double[] expectedRoots = { -3, -2 };

            // Act
            double[] actualRoots = QuadraticEquationSolver.SolveQuadraticEquation(a, b, c);

            // Assert
            CollectionAssert.AreEqual(expectedRoots, actualRoots);
        }

        [TestMethod]
        public void SolveQuadraticEquation_ValidInputWithOneRoot_ReturnsCorrectRoot()
        {
            // Arrange
            double a = 1, b = 2, c = 1;
            double[] expectedRoots = { -1 };

            // Act
            double[] actualRoots = QuadraticEquationSolver.SolveQuadraticEquation(a, b, c);

            // Assert
            CollectionAssert.AreEqual(expectedRoots, actualRoots);
        }

        [TestMethod]
        public void SolveQuadraticEquation_InvalidInputWithAEqualToZero_ThrowsArgumentException()
        {
            // Arrange
            double a = 0, b = 5, c = 6;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => QuadraticEquationSolver.SolveQuadraticEquation(a, b, c));
        }
    }

    [TestClass]
    public class YearDaysCounterTests
    {
        [TestMethod]
        public void GetDaysInYear_LeapYear_Returns366()
        {
            // Arrange
            int year = 2024;
            int expectedDays = 366;

            // Act
            int actualDays = YearDaysCounter.GetDaysInYear(year);

            // Assert
            Assert.AreEqual(expectedDays, actualDays);
        }

        [TestMethod]
        public void GetDaysInYear_NonLeapYear_Returns365()
        {
            // Arrange
            int year = 2023;
            int expectedDays = 365;

            // Act
            int actualDays = YearDaysCounter.GetDaysInYear(year);

            // Assert
            Assert.AreEqual(expectedDays, actualDays);
        }

        [TestMethod]
        public void GetDaysInYear_InvalidInputZero_ThrowsArgumentException()
        {
            // Arrange
            int year = 0;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => YearDaysCounter.GetDaysInYear(year));
        }
    }

    [TestClass]
    public class EmailValidatorTests
    {
        [TestMethod]
        public void IsValidEmail_ValidEmail_ReturnsTrue()
        {
            // Arrange
            string validEmail = "test@example.com";

            // Act
            bool isValid = EmailValidator.IsValidEmail(validEmail);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValidEmail_InvalidEmail_ReturnsFalse()
        {
            // Arrange
            string invalidEmail = "test@example";

            // Act
            bool isValid = EmailValidator.IsValidEmail(invalidEmail);

            // Assert
            Assert.IsFalse(isValid);
        }
    }

    [TestClass]
    public class DigitsSummerTests
    {
        [TestMethod]
        public void SumOfDigits_ValidNumber_ReturnsCorrectSum()
        {
            // Arrange
            string number = "123";
            int expectedSum = 6;

            // Act
            int actualSum = DigitsSummer.SumOfDigits(number);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]

        public void SumOfDigits_EmptyString_Returns0()
        {
            // Arrange
            string number = "";
            int expectedSum = 0;

            // Act
            int actualSum = DigitsSummer.SumOfDigits(number);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void SumOfDigits_StringWithNonDigits_ReturnsCorrectSum()
        {
            // Arrange
            string number = "a1b2c3";
            int expectedSum = 6;

            // Act
            int actualSum = DigitsSummer.SumOfDigits(number);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
