using NUnit.Framework;
using OpenQA.Selenium;

namespace KatalonR_Tests_POM.Pages
{
    internal class Ecommerce_Page
    {
        IWebDriver driver;
        By assert_title = By.XPath("//a[@href='http://opencart.abstracta.us:80/index.php?route=common/home']");
        By search_box = By.Name("search");
        By search_botton = By.XPath("//div[@id='search']/span/button");
        By selec_element = By.XPath("//img[contains(@src,'1-228x228.jpg')]");
        By cuantity_box = By.XPath("//input[contains(@id,'input-quantity')]");
        By add_boton = By.XPath("//button[contains(@id,'button-cart')]");

        public Ecommerce_Page(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("http://opencart.abstracta.us/index.php?route=common/home");
        }

        public void assertTitle()
        {
            Assert.IsTrue(driver.FindElement(assert_title).Displayed);
        }

        public void typeElement(string typeSearch)
        {
            driver.FindElement(search_box).SendKeys(typeSearch);
        }

        public void selectSearchBoton()
        {
            driver.FindElement(search_botton).Click();
        }

        public void clearSearhBox()
        {
            driver.FindElement(search_box).Clear();
        }

        public void clickOnElement()
        {
            driver.FindElement(selec_element).Click();
        }

        public void typeNumberElements(string inputQuantity)
        {
            driver.FindElement(cuantity_box).Clear(); // Primero hay que limiar la caja de texto que tiene por defecto la cantidad "1"
            driver.FindElement(cuantity_box).SendKeys(inputQuantity);
        }

        public void addToCart()
        {
            driver.FindElement(add_boton).Click();
        }
    }
}
