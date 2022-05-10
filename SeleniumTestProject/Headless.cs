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
    public class Headless
    {
        [Fact]
        public void CorrectTitleDisplayed()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");


            using var driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");
            Console.WriteLine("Title is :" + driver.Title);
            Assert.Equal("Sample page - lambdatest.com", driver.Title);
        }


    }
}
