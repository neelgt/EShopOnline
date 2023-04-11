using DocumentFormat.OpenXml.Drawing.Diagrams;
using Dynamitey.DynamicObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOnline.Pages
{
    public class AddItempage
    {
        public void scrollDown()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(1000);
        }

         IWebDriver driver;

        public AddItempage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By ConinueShopp = By.XPath("//form/div/div[3]/section[1]/a");

        //By Catalog = By.CssSelector(".esh-catalog-item.col-md-4");
        By pname = By.CssSelector(".esh-catalog-name");

        By Brand = By.XPath("//form/label[1]");
        By BrandName = By.XPath("(//option[@value='2'])[1]");
        By Type = By.XPath("//form/label[2]");
        By TypeName = By.XPath("(//option[@value='1'])[2]");
        By Apply = By.XPath(".//*[@class='esh-catalog-send']");
        By Add = By.CssSelector(".esh-catalog-button");
        
        

        public CheckoutPage AddItem()
        {
            string[] expectedProduct = {".NET BOT BLACK SWEATSHIRT", ".NET BLACK & WHITE MUG", "PRISM WHITE T-SHIRT" };

            IList<IWebElement> list = driver.FindElements(By.CssSelector(".esh-catalog-item.col-md-4"));
            //IList<IWebElement> name = driver.FindElements(By.CssSelector(".esh-catalog-name"));

            foreach (IWebElement element in list)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                if(expectedProduct.Contains(element.FindElement(pname).Text)) ;
                {
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    //Add to cart
                    element.FindElement(Add).Click();

                    scrollDown();

                    driver.FindElement(ConinueShopp).Click();
                }
            }


            /* Add item by applying filter*/

            driver.FindElement(Brand).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(BrandName).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            driver.FindElement(Type).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            driver.FindElement(TypeName).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            driver.FindElement(Apply).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            driver.FindElement(Add).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            return new CheckoutPage(driver);
        }

    }
}
