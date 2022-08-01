using KatalonR_Tests_POM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KatalonR_Tests_POM.Test
{
    internal class Form_Page_Test
    {
        private IWebDriver driver;
        private Form_Page form;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            form = new Form_Page(driver);
        }

        [Test]
        public void TestFormSubmit()
        {
            form.ingresaUserName("Jose");
            form.ingresaPass("pass1234");
            form.ingresaMail("mail@mail.com");
            form.seleccionaCheckbox2();
            form.seleccionaRadiobox2();
            form.seleccionaItem2();
            form.seleccionaDropItem2();
            form.seleccionaSubmit();
            form.assertSubmitForm();
            form.takeScreenshotSucessRegister();
            driver.Close();
        }

        [Test]
        public void TestFormCancel()
        {
            form.ingresaUserName("Jose");
            form.ingresaPass("pass1234");
            form.ingresaMail("mail@mail.com");
            form.seleccionaCheckbox2();
            form.seleccionaRadiobox2();
            form.seleccionaItem2();
            form.seleccionaDropItem2();
            form.seleccionaCancel();
            driver.Close();
        }
    }
}
