using KatalonR_Tests_POM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KatalonR_Tests_POM.Test
{
    internal class Calculator_Page_Test
    {
        private IWebDriver driver;
        private Calculator_Page calculate;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            calculate = new Calculator_Page(driver);
        }

        [Test]

        public void TestAddCalculate()
        {
            calculate.typeFirstNumber("1");
            calculate.typeSecondNumber("1");
            calculate.selectOpction("Add");
            calculate.selectCalculate();
            driver.Close();
        }

        [Test]

        public void TestDivideCalculate()
        {
            calculate.typeFirstNumber("3");
            calculate.typeSecondNumber("895");
            calculate.selectOpction("Divide");
            calculate.selectIntegers(); // redondea a un valor
            calculate.selectCalculate();
            driver.Close();
        }

        [Test]

        public void TestTryDivideLetter()
        {
            calculate.typeFirstNumber("3");
            calculate.typeSecondNumber("JJJ");
            calculate.selectOpction("Divide");
            calculate.selectCalculate();
            calculate.assertAnswer();
            driver.Close();
        }

        [Test]

        public void TestConcatenatePhrase()
        {
            calculate.typeFirstNumber("Hola");
            calculate.typeSecondNumber(" Mundo");
            calculate.selectOpction("Concatenate");
            calculate.selectCalculate();
            driver.Close();
        }
    }
}
