using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOnline.Pages
{
    public class InvalidLoginPage
    {
        IWebDriver driver;

        public InvalidLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By login = By.XPath("//*[@class='esh-identity-name esh-identity-name--upper']");
        By email = By.XPath(".//*[@id='Input_Email']");
        By password = By.XPath(".//*[@id='Input_Password']");
        By validate = By.XPath(".//*[@class='btn btn-default']");

        public void ClickLogin()
        {
            driver.FindElement(login).Click();
        }
        public void ClickEmail(string text)
        {
            driver.FindElement(email).SendKeys(text);
        }
        public void ClickPassword(string text)
        {
            driver.FindElement(password).SendKeys(text);
        }
        public void Validate()
        {
            driver.FindElement(validate).Click();
            bool msg = driver.FindElement(By.XPath("//form/div[1]")).Displayed;

            if (msg == true)
            {
                Console.WriteLine("Invalid input");
            }
            
        }
    }
}
