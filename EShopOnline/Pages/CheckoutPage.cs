using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOnline.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By checkout = By.XPath("(//*[@class='btn esh-basket-checkout'])[2]");

        public PlaceOrderPage ClickOnCheckout()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(1000);
            driver.FindElement(checkout).Click();
            return new PlaceOrderPage(driver);
        }
            
            
        
    }
}
