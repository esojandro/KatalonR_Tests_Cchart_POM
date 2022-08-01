using System.Text;
using KatalonR_Tests_POM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KatalonR_Tests_POM.Test
{
    internal class Resgistro_Page_Test
    {
        private IWebDriver driver;
        private Register_Page register;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            register = new Register_Page(driver);
        }

        [Test]
        public void TestMailDuplicado()
        {
            register.ingresaUserName("Brand");
            register.ingresaLastName("Dovarn");
            register.ingresaEmail("email@email.com");
            register.ingresaPhone("96857423");
            register.ingresaPass("pas123");
            register.confirmPass("pas123");
            register.checkAgree();
            register.clickBoton();
            register.confirmTextMailDuplicado();
            driver.Close();
        }

        [Test]
        public void TestWrongPassConfirm()
        {
            register.ingresaUserName("Brand");
            register.ingresaLastName("Dovarn");
            register.ingresaEmail("email@email.com");
            register.ingresaPhone("96857423");
            register.ingresaPass("pas123");
            register.confirmPass("pas1234");
            register.checkAgree();
            register.clickBoton();
            register.confirmTextWrongLogin();
            driver.Close();
        }

        //[Test] // AL ingresar correo se muestra una ventana que no se puede validad
        //public void TestNoMailCharacters()
        //{
        //    register.ingresaUserName("Brand");
        //    register.ingresaLastName("Dovarn");
        //    register.ingresaEmail("email");
        //    register.ingresaPhone("96857423");
        //    register.ingresaPass("pas123");
        //    register.confirmPass("pas123");
        //    register.checkAgree();
        //    register.clickBoton();
        //    register.confirmTextWrongLogin();
        //    driver.Close();
        //}

        //[Test] // La pag+ina permite registrarse sin aceptar las politicas de privacidad
        //public void TestNoAgreePrivacyPolicity()
        //{
        //    register.ingresaUserName("Brand");
        //    register.ingresaLastName("Dovarn");
        //    register.ingresaEmail("email");
        //    register.ingresaPhone("96857423");
        //    register.ingresaPass("pas123");
        //    register.confirmPass("pas123");
        //    register.checkAgree();
        //    register.clickBoton();
        //    register.confirmTextWrongLogin();
        //    driver.Close();
        //}

        //[Test] // La pagina en este caso si acepta letras en campos numericos 
        //public void TestLettersInPhone()
        //{
        //    register.ingresaUserName("Brand");
        //    register.ingresaLastName("Dovarn");
        //    register.ingresaEmail("email");
        //    register.ingresaPhone("Letters");
        //    register.ingresaPass("pas123");
        //    register.confirmPass("pas123");
        //    register.checkAgree();
        //    register.clickBoton();
        //    register.confirmTextWrongLogin();
        //    driver.Close();
        //}
    }
}
