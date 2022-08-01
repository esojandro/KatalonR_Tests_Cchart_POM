
using NUnit.Framework;
using OpenQA.Selenium;

namespace KatalonR_Tests_POM.Pages
{
    internal class Form_Page
    {
        IWebDriver driver;
        // Selectors
        By name = By.XPath("//input[contains(@name,'username')]");
        By password = By.XPath("//input[contains(@type,'password')]");
        By email = By.XPath("//textarea[@cols='40'][contains(.,'Comments...')]");
        By checkbox_position_2 = By.XPath("//input[contains(@value,'cb2')]");
        By radio_item_2 = By.XPath("//input[contains(@value,'rd2')]");
        By selection_item_2 = By.XPath("//option[@value='ms2'][contains(.,'Selection Item 2')]");
        By Dropdown_item_2 = By.XPath("/html/body/div/div[3]/form/table/tbody/tr[8]/td/select/option[2]");
        By boton_sudmit = By.XPath("//input[contains(@type,'submit')]");
        By boton_cancel = By.XPath("//input[contains(@type,'reset')]");
        By assert_submit = By.XPath("//h1[contains(.,'Processed Form Details')]");

        // Methods

        public Form_Page(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://testpages.herokuapp.com/styled/basic-html-form-test.html");
        }

        public void ingresaUserName(string userName)
        {
            driver.FindElement(name).SendKeys(userName);
        }

        public void ingresaPass(string pass)
        {
            driver.FindElement(password).SendKeys(pass);
        }

        public void ingresaMail(string mail)
        {
            driver.FindElement(email).SendKeys(mail);
        }

        public void seleccionaCheckbox2()
        {
            driver.FindElement(checkbox_position_2).Click();
        }

        public void seleccionaRadiobox2()
        {
            driver.FindElement(radio_item_2).Click();
        }

        public void seleccionaItem2()
        {
            driver.FindElement(selection_item_2).Click();
        }

        public void seleccionaDropItem2()
        {
            driver.FindElement(Dropdown_item_2).Click();
        }

        public void seleccionaSubmit()
        {
            driver.FindElement(boton_sudmit).Click();
        }

        public void seleccionaCancel()
        {
            driver.FindElement(boton_cancel).Click();
        }
        public void assertSubmitForm()
        {
            Assert.IsTrue(driver.FindElement(assert_submit).Displayed);
        }

        public void takeScreenshotSucessRegister()
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("Form_Exitoso.png", ScreenshotImageFormat.Png);
        }
    }
}
