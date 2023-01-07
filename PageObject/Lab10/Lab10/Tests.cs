using Lab10.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Lab10
{
    public class Tests
    {
        [Test]
        public void SearchColorHomePrinterTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.canon.ru/";

            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(80);

            mainMenu.ClickYesCookie()
                .HoverProductElement()
                .HoverPrintersElement()
                .ClickPrintersElement()
                .HomePrintersClick()
                .SearchFilterClick()
                .ColorCheckboxClick()
                .SearchRelustClick();
        }

        [Test]
        public void SearchComponent()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.canon.ru/";

            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            mainMenu.ClickYesCookie()
                .ClickSearchText()
                .ClickSearchTextField("Canon 1300d");
        }
    }    
}