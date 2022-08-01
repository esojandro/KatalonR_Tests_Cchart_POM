using NUnit.Framework;
using OpenQA.Selenium;

namespace KatalonR_Tests_POM.Pages
{
    internal class Calculator_Page
    {
        IWebDriver driver;
        By first_Number = By.XPath("//input[contains(@id,'number1Field')]");
        By second_Number = By.XPath("//input[contains(@id,'number2Field')]");        
        By opcion_box = By.XPath("//select[contains(@id,'selectOperationDropdown')]");
        By botom_calculate = By.XPath("//input[contains(@id,'calculateButton')]");
        By assert_answer = By.XPath("//label[contains(@id,'errorMsgField')]");
        By integers_option = By.XPath("//input[contains(@id,'integerSelect')]");
        By clear_option = By.XPath("//input[contains(@id,'clearButton')]");

        public Calculator_Page(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://testsheepnz.github.io/BasicCalculator.html");
        }

        public void typeFirstNumber(string firstNumber)
        {
            driver.FindElement(first_Number).SendKeys(firstNumber);
        }

        public void typeSecondNumber(string secondNumber)
        {
            driver.FindElement(second_Number).SendKeys(secondNumber);
        }

        public void selectOpction(string option)
        {
            driver.FindElement(opcion_box).SendKeys(option);
        }

        public void selectCalculate()
        {
            driver.FindElement(botom_calculate).Click();
        }

        public void assertAnswer()
        {
            Assert.IsTrue(driver.FindElement(assert_answer).Displayed);
        }

        public void selectIntegers()
        {
            driver.FindElement(integers_option).Click();
        }

        public void selectClear()
        {
            driver.FindElement(clear_option).Click();
        }
    }
}
