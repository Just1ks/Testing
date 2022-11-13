using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FunctionalTests
{
    public class Tests
    {
        [Test]
        public void FindingWIFIHomeColorPrinter()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.canon.ru/";

        }
    }
}