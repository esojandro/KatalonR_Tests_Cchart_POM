using NUnit.Framework;
using OpenQA.Selenium;

namespace KatalonR_Tests_POM.Pages
{
    public class Login_Page
    {
        IWebDriver driver;
        By userEmail = By.Id("input-email");
        By password = By.Id("input-password");
        By login_button = By.XPath("//input[contains(@type,'submit')]");
        By text_sucess_login = By.XPath("(//a[contains(@class,'list-group-item')])[13]");
        By text_wrong_login = By.XPath("//div[@class='alert alert-danger alert-dismissible']");

        public Login_Page(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://opencart.abstracta.us/index.php?route=account/login");
        }

        public void ingresaEmail(string mail)
        {
            driver.FindElement(userEmail).SendKeys(mail);
        }

        public void ingresaPass(string pass)
        {
            driver.FindElement(password).SendKeys(pass);
        }

        public void clickBoton()
        {
            driver.FindElement(login_button).Click();
        }

        public void confirmTextSuccessLogin()
        {
            Assert.IsTrue(driver.FindElement(text_sucess_login).Displayed);
        }

        public void confirmTextWrongLogin()
        {
            Assert.IsTrue(driver.FindElement(text_wrong_login).Displayed);
        }

        public void takeScreenshotSucessLogin()
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("Ingreso_Exitoso.png", ScreenshotImageFormat.Png);
        }
    }
}
