using KatalonR_Tests_POM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KatalonR_Tests_POM.Test
{
    class Login_Page_Test
    {
        private IWebDriver driver;
        private Login_Page login;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            login = new Login_Page(driver);
        }

        [Test]
        public void SuccessLogin() // Este no deberia de automatizar por lo mismo que pasaba en el caso de registrar
        {
            login.ingresaEmail("mail@email.com");
            login.ingresaPass("pas123");
            login.clickBoton();
            login.confirmTextSuccessLogin();
            login.takeScreenshotSucessLogin();
            driver.Quit();
        }

        [Test]
        public void passWrongToLogin()
        {
            login.ingresaEmail("mail@email.com");
            login.ingresaPass("pas123556+");
            login.clickBoton();
            login.confirmTextWrongLogin();
            login.takeScreenshotSucessLogin();
            driver.Quit();
        }

        [Test]
        public void mailWrongToLogin()
        {
            login.ingresaEmail("mailmaikl");
            login.ingresaPass("pas123");
            login.clickBoton();
            login.confirmTextWrongLogin();
            login.takeScreenshotSucessLogin();
            driver.Quit();
        }

        [Test]
        
        public void passInMailBox()
        {
            login.ingresaEmail("pas123");
            login.ingresaPass("pas123");
            login.clickBoton();
            login.confirmTextWrongLogin();
            login.takeScreenshotSucessLogin();
            driver.Quit();
        }
    }
}
