using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOnline.Pages
{
    public class PlaceOrderPage
    {
        private IWebDriver driver;

        public PlaceOrderPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By pay = By.XPath("//*[@value='[ Pay Now ]']");
        By c_order = By.CssSelector("div.container h1");

        public void CliclOnPayNow()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(3000);
            driver.FindElement(pay).Click();

            string expectedMessage = driver.FindElement(c_order).Text;
            string c_msg = "Thanks for your Order!";
            
            Assert.AreEqual(expectedMessage, c_msg);

        }
    }
}
