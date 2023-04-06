using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using EShopOnline.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EShopOnline.StepDefinitions
{
    [Binding]
    public class ValidateLoginStepDefinitions
    {
        IWebDriver driver;
        InvalidLoginPage invalidLoginPage;

        public ValidateLoginStepDefinitions(IWebDriver driver) 
        {
            this.driver = driver;
        }

        /* Steps for Invalid Login Validation*/

        [Given(@"Navigate to Home Page")]
        public void GivenNavigateToHomePage()
        {
            driver.Navigate().GoToUrl("https://localhost:44315/");
        }
        
        [Then(@"Click login")]
        public void ThenClickLogin()
        {
            invalidLoginPage = new InvalidLoginPage(driver);

            invalidLoginPage.ClickLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"Enter mail '([^']*)'")]
        public void WhenEnterMail(string mail)
        {
            invalidLoginPage = new InvalidLoginPage(driver);

            invalidLoginPage.ClickEmail(mail);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"Enter pass '([^']*)'")]
        public void WhenEnterPass(string pass)
        {
            invalidLoginPage = new InvalidLoginPage(driver);

            invalidLoginPage.ClickPassword(pass);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Then(@"Invalid login")]
        public void ThenInvalidLogin()
        {
            invalidLoginPage = new InvalidLoginPage(driver);

            invalidLoginPage.Validate();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}
