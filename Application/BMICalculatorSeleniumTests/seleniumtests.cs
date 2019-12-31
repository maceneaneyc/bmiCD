//namespace SeleniumTests
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace SeleniumTests.FunctionalTests
{
    [TestClass]
    public class SeleniumFunctionalTests
    {
        private static TestContext testContext;
        private RemoteWebDriver driver;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            SeleniumFunctionalTests.testContext = testContext;
        }

        [TestInitialize]
        public void TestInit()
        {
            driver = GetChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
        }

        [TestCleanup]
        public void TestClean()
        {
            driver.Quit();
        }

        [TestMethod]
        public void BMIFunctionalTest()
        {
            var webAppUrl = testContext.Properties["webAppUrl"].ToString();

            // var startTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            // var endTimestamp = startTimestamp + (60 * 10);

            // Arrange
            double expectedBMIResult = 18.55;
            string expectedResult = "Your BMI is " + expectedBMIResult;

            // Act
            driver.Navigate().GoToUrl(webAppUrl);
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.Id("BMI_WeightStones")).Click();
            driver.FindElement(By.Id("BMI_WeightStones")).SendKeys("8");
            driver.FindElement(By.Id("BMI_WeightPounds")).SendKeys("10");
            driver.FindElement(By.Id("BMI_HeightFeet")).SendKeys("5");
            driver.FindElement(By.Id("BMI_HeightInches")).SendKeys("8");
            driver.FindElement(By.CssSelector(".btn")).Click();

            string actualResult = driver.FindElement(By.Id("BMIValue")).Text;

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void BMICategoryFunctionalTest()
        {
            var webAppUrl = testContext.Properties["webAppUrl"].ToString();

            // var startTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            // var endTimestamp = startTimestamp + (60 * 10);

            // Arrange
            string expectedBMICategoryResult = "Normal";
            string expectedResult = "Your BMI Category is " + expectedBMICategoryResult;

            // Act
            driver.Navigate().GoToUrl(webAppUrl);
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.Id("BMI_WeightStones")).Click();
            driver.FindElement(By.Id("BMI_WeightStones")).SendKeys("8");
            driver.FindElement(By.Id("BMI_WeightPounds")).SendKeys("10");
            driver.FindElement(By.Id("BMI_HeightFeet")).SendKeys("5");
            driver.FindElement(By.Id("BMI_HeightInches")).SendKeys("8");
            driver.FindElement(By.CssSelector(".btn")).Click();

            string actualResult = driver.FindElement(By.Id("BMICategory")).Text;

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void BMIWeightMetricFunctionalTest()
        {
            var webAppUrl = testContext.Properties["webAppUrl"].ToString();

            // var startTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            // var endTimestamp = startTimestamp + (60 * 10);

            // Arrange
            double expectedBMIWeightMetricResult = 55.34;
            string expectedResult = "Your BMI Category is " + expectedBMIWeightMetricResult;

            // Act
            driver.Navigate().GoToUrl(webAppUrl);
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.Id("BMI_WeightStones")).Click();
            driver.FindElement(By.Id("BMI_WeightStones")).SendKeys("8");
            driver.FindElement(By.Id("BMI_WeightPounds")).SendKeys("10");
            driver.FindElement(By.Id("BMI_HeightFeet")).SendKeys("5");
            driver.FindElement(By.Id("BMI_HeightInches")).SendKeys("8");
            driver.FindElement(By.CssSelector(".btn")).Click();

            string actualResult = driver.FindElement(By.Id("BMIWeightMetric")).Text;

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void BMIHeightMetricFunctionalTest()
        {
            var webAppUrl = testContext.Properties["webAppUrl"].ToString();

            // var startTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            // var endTimestamp = startTimestamp + (60 * 10);

            // Arrange
            double expectedBMIHeightMetricResult = 1.73;
            string expectedResult = "Your BMI Category is " + expectedBMIHeightMetricResult;

            // Act
            driver.Navigate().GoToUrl(webAppUrl);
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.Id("BMI_WeightStones")).Click();
            driver.FindElement(By.Id("BMI_WeightStones")).SendKeys("8");
            driver.FindElement(By.Id("BMI_WeightPounds")).SendKeys("10");
            driver.FindElement(By.Id("BMI_HeightFeet")).SendKeys("5");
            driver.FindElement(By.Id("BMI_HeightInches")).SendKeys("8");
            driver.FindElement(By.CssSelector(".btn")).Click();

            string actualResult = driver.FindElement(By.Id("BMIHeightMetric")).Text;

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        private RemoteWebDriver GetChromeDriver()
        {
            var path = Environment.GetEnvironmentVariable("ChromeWebDriver");
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox");
            options.AddArguments("headless");

            if (!string.IsNullOrWhiteSpace(path))
            {
                return new ChromeDriver(path, options, TimeSpan.FromSeconds(300));
            }
            else
            {
                return new ChromeDriver(options);
            }
        }
    }
}
