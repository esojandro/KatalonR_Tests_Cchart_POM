using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Wrapper Class Selenium
// In this class find the Selenium Methods
// In case of change version of selenium and methods are renamed

namespace KatalonR_Tests_POM
{
    internal class Base
    {
        private WebDriver driver;

        public Base(WebDriver driver)
        {
            this.driver = driver;
        }

        public WebDriver chromeDriver()
        {
            //have two ways to rie
            // this way:
            //IWebDriver driver = new ChromeDriver();
            // or
            // this way:
            driver = new ChromeDriver();
            return driver;
        }

        //public WebElement findElement(By locator)
        //{
        //    return driver.FindElement(locator);
        //}

        public void click(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public Boolean isDisplayed(By locator)
        {
            try
            {
                return driver.FindElement(locator) != null;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public void pagevisit(string url)
        //{
        //    driver.gettype(url);
        //}
    }
}
