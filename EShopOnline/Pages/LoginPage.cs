﻿using EShopOnline.Utility;
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

        public void EnterCredetial(Table table)
        {
            var dictionary = TableToDict.ToDict(table);

            driver.FindElement(email).SendKeys(dictionary["username"]);
            driver.FindElement(password).SendKeys(dictionary["password"]);
        }

        public AddItempage ClickOnLog()
        {
            driver.FindElement(log).Click();
            string email = driver.FindElement(By.XPath("(//img[@class='esh-identity-image'])[1]/parent::section/div")).Text;
            try
            {
                if (email != "LOGIN")
                {
                    Console.WriteLine("Valid Login");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return new AddItempage(driver);
        }

    }
}
 