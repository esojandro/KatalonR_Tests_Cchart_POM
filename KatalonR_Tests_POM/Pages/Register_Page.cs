using NUnit.Framework;
using OpenQA.Selenium;

namespace KatalonR_Tests_POM.Pages
{
    internal class Register_Page
    {
        IWebDriver driver;
        By userName = By.Id("input-firstname");
        By userLast_name = By.Id("input-lastname");
        By userEmail = By.Id("input-email");
        By userPhone = By.Id("input-telephone");
        By password = By.Id("input-password");
        By confirm_password = By.Id("input-confirm");
        By check_agre = By.Name("agree");
        By register_button = By.XPath("//input[@value='Continue']");
        By text_double_email = By.XPath("//div[@class='alert alert-danger alert-dismissible']");
        By text_wrong_register = By.XPath("//div[@class='text-danger'][contains(.,'Password confirmation does not match password!')]");

        public Register_Page(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://opencart.abstracta.us/index.php?route=account/register");
        }

        public void ingresaUserName(string name)
        {
            driver.FindElement(userName).SendKeys(name);
        }

        public void ingresaLastName(string lastName)
        {
            driver.FindElement(userLast_name).SendKeys(lastName);
        }

        public void ingresaEmail(string mail)
        {
            driver.FindElement(userEmail).SendKeys(mail);
        }
        public void ingresaPhone(string phone)
        {
            driver.FindElement(userPhone).SendKeys(phone);
        }
        public void ingresaPass(string pass)
        {
            driver.FindElement(password).SendKeys(pass);
        }
        public void confirmPass(string confirm_pass)
        {
            driver.FindElement(confirm_password).SendKeys(confirm_pass);
        }
        public void clickBoton()
        {
            driver.FindElement(register_button).Click();
        }

        public void checkAgree()
        {
            driver.FindElement(check_agre).Click();
        }

        public void confirmTextMailDuplicado()
        {
            Assert.IsTrue(driver.FindElement(text_double_email).Displayed);
        }

        public void confirmTextWrongLogin()
        {
            Assert.IsTrue(driver.FindElement(text_wrong_register).Displayed);
        }

        public void takeScreenshotSucessRegister()
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("Ingreso_Exitoso.png", ScreenshotImageFormat.Png);
        }
    }
}
