
using KatalonR_Tests_POM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KatalonR_Tests_POM.Test
{
    internal class Ecommerce_Page_Test
    {
        private IWebDriver driver;
        private Ecommerce_Page commerce;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            commerce = new Ecommerce_Page(driver);
        }

        [Test]
        public void TestSearhElement()
        {
            commerce.assertTitle();
            commerce.typeElement("phone");
            commerce.selectSearchBoton();
            driver.Close(); 
        }

        [Test]
        public void TestAddSixElements()
        {
            //TestSearhElement(); // Llamo al test anterior para partir de busqueda // no funciona porque los test se abren en ventanas diferentes
            commerce.assertTitle();
            commerce.typeElement("phone");
            commerce.selectSearchBoton();
            commerce.clickOnElement();
            commerce.typeNumberElements("6"); // Tiene un .clear en el metodo que limpia valores por defecto
            commerce.addToCart();
            driver.Close();
        }

        [Test]
        public void TestSearhTwoElements()
        {
            commerce.assertTitle();
            commerce.typeElement("display");
            commerce.selectSearchBoton();
            commerce.clearSearhBox(); // Limpia la cada de texto para hacer una nueva busqueda ver test anterior donde el .Clear se usa dentro de un método
            commerce.typeElement("phone");
            commerce.selectSearchBoton();
            driver.Close();
        }
    }
}
