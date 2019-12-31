using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BMIUnitTestProject
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class UnitTestBMICategory
    {
        [TestMethod]
        public void TestUnderweightBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 6, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 0;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestNormalBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 1;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestOverweightBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 14, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 2;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestObeseBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 16, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 3;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMIMetricWeightMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 10, WeightPounds = 6, HeightFeet = 5, HeightInches = 7 };
            double expectedResult = 66.224432;

            //Act
            double actualResult = bmi.BMIWeightMetric;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestBMIMetricHeightMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 10, WeightPounds = 6, HeightFeet = 5, HeightInches = 7 };
            double expectedResult = 1.7018;

            //Act
            double actualResult = bmi.BMIHeightMetric;

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

    }
}
