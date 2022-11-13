using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FunctionalTests
{
    public class Tests
    {
        [Test]
        public void FindingColorPrinterEPSON()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.21vek.by/";

            driver.FindElement(By.Id("catalogSearch")).SendKeys("Принтеры");
            driver.FindElement(By.Id("catalogSearch")).SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("//*[@id='j-filter__form']/div[2]/dl/div/dd[4]/label")).Click();

            driver.FindElement(By.XPath("//*[@id='j-filter__form']/div[3]/dl[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='j-filter__form']/div[3]/dl[4]/div/dd[1]/label")).Click();

            driver.FindElement(By.Id("j-filter__btn")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
    }
}