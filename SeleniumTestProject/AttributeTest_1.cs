using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using Xunit;

namespace SeleniumTestProject
{
    public class AttributesTest_1 : IDisposable
    {
        private IWebDriver driver;

        public AttributesTest_1()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Fact]
        public void TitleDisplayed()
        {
            driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");
            Console.WriteLine("Title is :" + driver.Title);
            Assert.Equal("Sample page - lambdatest.com", driver.Title);
        }

        [Fact]
        public void dateDisplayed()
        {
            driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");
            IWebElement input = driver.FindElement(By.Id("sampletodotext"));
            DateTime birthday = new DateTime(1990, 10, 20);
            input.SendKeys(birthday.ToString("d"));

            var addButton = driver.FindElement(By.Id("addbutton"));
            addButton.Click();

        }

        public void Dispose()
        {
            //driver.Close();
        }
    }
}
