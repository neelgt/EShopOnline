using EShopOnline.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace EShopOnline.StepDefinitions 
{
    /*[TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(FirefoxDriver))]*/

    [Binding]
    public class EShopStepDefinitions
    {
        public IWebDriver driver;
        InvalidLoginPage invalidLoginPage;
        LoginPage loginPage;
        AddItempage addItempage;
        CheckoutPage checkoutPage;
        PlaceOrderPage placeOrderPage;

        public EShopStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        /* Steps for Login Validation*/

        [Given(@"Open Home Page")]
        public void GivenOpenHomePage()
        {
            driver.Url = "https://localhost:44315/";
        }

        [Then(@"Click on login")]
        public void ThenClickOnLogin()
        {
            invalidLoginPage = new InvalidLoginPage(driver);

            invalidLoginPage.ClickLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"Enter email '([^']*)'")]
        public void WhenEnterEmail(string email)
        {
            loginPage = new LoginPage(driver);

            loginPage.ClickOnEmail(email);
            Thread.Sleep(1000);
        }

        [When(@"Enter password '([^']*)'")]
        public void WhenEnterPassword(string pass)
        {
            loginPage = new LoginPage(driver);

            loginPage.ClickOnPassword(pass);
            Thread.Sleep(1000);
        }

        [Then(@"Successfull login")]
        public void ThenSuccessfullLogin()
        {
            loginPage = new LoginPage(driver);

            loginPage.ClickOnLog();
            Thread.Sleep(1000);
        }

        /* Add Items */

        [When(@"Add item")]
        public void WhenAddItem()
        {
            addItempage = new AddItempage(driver);

            addItempage.AddItem();
            Thread.Sleep(1000);

        }

        [Then(@"Go to checkout")]
        public void ThenGoToCheckout()
        {
            checkoutPage = new CheckoutPage(driver);

            checkoutPage.ClickOnCheckout();
            Thread.Sleep(1000);

        }

        [Then(@"Place order")]
        public void ThenPlaceOrder()
        {
            placeOrderPage = new PlaceOrderPage(driver);

            placeOrderPage.CliclOnPayNow();
            Thread.Sleep(1000);
        }
    }
}
