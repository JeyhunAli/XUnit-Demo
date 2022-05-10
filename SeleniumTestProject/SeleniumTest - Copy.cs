using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject
{ 
    //here dispose just teardown the test
    public class AttributesTest : IDisposable
    { 
    

        private IWebDriver driver;
    

        public AttributesTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Fact]    
        public void CorrectTitleDisplayed()
        {
            driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");
            Console.WriteLine("Title is :" + driver.Title);
            Assert.Equal("Sample page - lambdatest.com", driver.Title);
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}

