using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.Helpers;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace SeleniumTestProject
{
    //here dispose just teardown the test
    public class SeleniumTest2 
    {
        [Fact]
        public void CorrectTitleDisplayed()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            
            using var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");
            Console.WriteLine("Title is :" + driver.Title);
            Assert.Equal("Sample page - lambdatest.com", driver.Title);
        }

      
    }
}