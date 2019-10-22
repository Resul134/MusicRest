using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
// NuGet packages must be updated to 3.141

namespace HelloAppTest
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\Users\\resul\\Desktop\\3.semester\\driver";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory); // fast
                                                         //_driver = new FirefoxDriver(DriverDirectory);  // slow
                                                         // _driver = new EdgeDriver(DriverDirectory); // times out ... not working
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void Addition()
        {
            _driver.Navigate().GoToUrl("http://localhost:3000/");

            IWebElement buttonElement = _driver.FindElement(By.Id("getAllButton"));
            buttonElement.Click();

            IWebElement outputElement = _driver.FindElement(By.Id("getAllOutput"));
            string text = outputElement.Text;
        

            Assert.AreEqual("<ol><li>Title: From - Artist: Christian - Duration: 3.43 - Year of publication: 2019</li><li>Title: Wow - Artist: Resul - Duration: 3.43 - Year of publication: 2018</li></ol>", text);

            //IWebElement inputElement = _driver.FindElement(By.Id("calcInput1"));
            //inputElement.SendKeys("5");

            //IWebElement inputElement2 = _driver.FindElement(By.Id("calcInput2"));
            //inputElement2.SendKeys("10");


            //IWebElement buttonElement = _driver.FindElement(By.Id("buttonCalculate"));
            //buttonElement.Click();


            //IWebElement outputElement = _driver.FindElement(By.Id("calcOutput"));
            //string text = outputElement.Text;

            //Assert.AreEqual("15", text);


        }

    //    [TestMethod]
    //    public void testMinus()
    //    {

    //        _driver.Navigate().GoToUrl("http://localhost:3002/");

    //        IWebElement inputElement = _driver.FindElement(By.Id("calcInput1"));
    //        inputElement.SendKeys("5");

    //        IWebElement inputElement2 = _driver.FindElement(By.Id("calcInput2"));
    //        inputElement2.SendKeys("10");

    //        SelectElement select = new SelectElement(_driver.FindElement(By.Id("SelectedNumber")));
    //        select.SelectByIndex(1);

    //        IWebElement buttonElement = _driver.FindElement(By.Id("buttonCalculate"));
    //        buttonElement.Click();

    //        IWebElement outputElement = _driver.FindElement(By.Id("calcOutput"));
    //        string text = outputElement.Text;

    //        Assert.AreEqual(text, "5");

    //    }
    }
}
