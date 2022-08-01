using KatalonR_Tests_POM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KatalonR_Tests_POM.Test
{
    internal class Shop_Page_Test
    {
        private IWebDriver driver;
        private Shop_Page shop;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            shop = new Shop_Page(driver);
        }

        [Test]

        public void TestOrderProduct()
        {
            shop.assertPageTitle();
            shop.selectProduct();
            shop.writeCuantity("6");
            shop.addProduct();
            shop.viewCart();
            shop.clickCheckout();
            driver.Quit();
        }

        [Test]

        public void TestOrderChangeAddress()
        {
            shop.assertPageTitle();
            shop.selectProduct();
            shop.writeCuantity("6");
            shop.addProduct();
            shop.viewCart();
            shop.clickCheckout();
            shop.writeFisrtName("Jose");
            shop.writeLastName("Romero");
            shop.writeStreet("Calle Principal");
            shop.changeTown("Pérez Zeledón");
            shop.changeState("San José");
            shop.addZip("11901");
            shop.writePhone("98765432");
            shop.writeMail("mail@mail.com");
            //shop.orderProduct();
            //shop.assertOrder();
            driver.Quit();
        }
    }
}
