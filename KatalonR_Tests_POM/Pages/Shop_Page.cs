using NUnit.Framework;
using OpenQA.Selenium;

namespace KatalonR_Tests_POM.Pages
{
    internal class Shop_Page
    {
        IWebDriver driver;
        By assert_page_title = By.XPath("//h1[contains(.,'Shop')]");
        By select_product = By.XPath("(//img[contains(@class,'thumbnail')])[1]");
        By write_cuantity = By.XPath("//input[contains(@type,'number')]");
        By add_botton = By.XPath("//button[@type='submit'][contains(.,'Add to cart')]");
        By assert_add_product = By.XPath("//div[@class='woocommerce-message']");
        By view_cart = By.XPath("//a[@tabindex='1']");
        By write_state = By.XPath("//input[contains(@id,'billing_state')]");
        By write_town = By.XPath("//input[contains(@id,'billing_city')]");
        By write_zip = By.XPath("//input[contains(@id,'billing_postcode')]");
        By checkout_botton = By.XPath("//a[@class='checkout-button button alt wc-forward']");
        By write_frist_name = By.XPath("//input[@id='billing_first_name']");
        By write_last_name = By.XPath("//input[contains(@id,'billing_last_name')]");
        By write_street = By.XPath("//input[contains(@name,'billing_address_1')]");
        By write_phone = By.XPath("//input[contains(@id,'billing_phone')]");
        By write_email = By.XPath("//input[@id='billing_email']");
        By order_botton = By.Id("place_order");
        By assert_order = By.XPath("//p[contains(.,'Thank you. Your order has been received.')]");

        public Shop_Page(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://cms.demo.katalon.com/");
        }

        public void assertPageTitle() { Assert.IsTrue(driver.FindElement(assert_page_title).Displayed); }

        public void selectProduct() { driver.FindElement(select_product).Click();  }

        public void writeCuantity(string cuantity) 
        {
            driver.FindElement(write_cuantity).Clear();
            driver.FindElement(write_cuantity).SendKeys(cuantity); 
        }

        public void addProduct() { driver.FindElement(add_botton).Click(); }

        public void assertAddProduct() { Assert.IsTrue(driver.FindElement(assert_add_product).Displayed); }

        public void viewCart() { driver.FindElement(view_cart).Click(); }

        public void changeState(String state) { driver.FindElement(write_state).SendKeys(state); }

        public void changeTown(String town) { driver.FindElement(write_town).SendKeys(town); }

        public void addZip(String zip) { driver.FindElement(write_zip).SendKeys(zip); }

        public void clickCheckout() { driver.FindElement(checkout_botton).Click(); }

        public void writeFisrtName(string fristName) { driver.FindElement(write_frist_name).SendKeys(fristName); }

        public void writeLastName(string lastName) { driver.FindElement(write_last_name).SendKeys(lastName); }

        public void writeStreet(string street) { driver.FindElement(write_street).SendKeys(street); }

        public void writePhone(string phone) { driver.FindElement(write_phone).SendKeys(phone); }

        public void writeMail(string mail) { driver.FindElement(write_email).SendKeys(mail); }

        public void orderProduct() { driver.FindElement(order_botton).Click(); }

        public void assertOrder() { Assert.IsTrue(driver.FindElement(assert_order).Displayed); }
    }
}
