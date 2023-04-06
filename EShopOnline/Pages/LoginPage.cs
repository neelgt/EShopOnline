using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOnline.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        By email = By.XPath(".//*[@id='Input_Email']");
        By password = By.XPath(".//*[@id='Input_Password']");
        By log = By.XPath(".//*[@class='btn btn-default']");

        public void ClickOnEmail(string text)
        {
            driver.FindElement(email).Clear();
            driver.FindElement(email).SendKeys(text);
        }
        public void ClickOnPassword(string text) 
        {
            driver.FindElement(password).SendKeys(text);
        }

        public AddItempage ClickOnLog()
        {
            driver.FindElement(log).Click();
            string email = driver.FindElement(By.XPath("(//img[@class='esh-identity-image'])[1]/parent::section/div")).Text;
            
            if (email != "LOGIN")
            {
                Console.WriteLine("Valid Login");
            }
            return new AddItempage(driver);
        }

    }
}
 