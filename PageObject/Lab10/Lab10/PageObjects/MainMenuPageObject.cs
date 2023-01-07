using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver driver;
        private Actions action;

        private readonly By YesCookieButton = By.Id("_evidon-accept-button");
        private readonly By ProductElementMenu = By.XPath("//a[@class='nav__menu-link canon-color--grey-darkest canon-paragraph--medium']");
        private readonly By PrintersElementMenu = By.LinkText("Принтеры");
        private readonly By SearchElement = By.XPath("//button[@class='nav__search-btn nav__search-btn--desktop canon-color--grey-darkest canon-paragraph--title-small']");
        private readonly By SearchElementField = By.Id("nav__search-form-input");

        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);            
        }

        public MainMenuPageObject HoverProductElement()
        {
            action.MoveToElement(driver.FindElement(ProductElementMenu));
            action.Perform();
            return this;
        }

        public MainMenuPageObject ClickYesCookie()
        {
            driver.FindElement(YesCookieButton).Click();
            return this;
        }

        public MainMenuPageObject HoverPrintersElement()
        {
            action.MoveToElement(driver.FindElement(PrintersElementMenu));
            action.Perform();
            return this;
        }

        public PrintersPageObject ClickPrintersElement()
        {
            action.MoveToElement(driver.FindElement(PrintersElementMenu)).Click();
            action.Perform();
            return new PrintersPageObject(driver);
        }

        public MainMenuPageObject ClickSearchText()
        {
            action.MoveToElement(driver.FindElement(SearchElement)).Click();
            action.Perform();
            return this;
        }
        public MainMenuPageObject ClickSearchTextField(string SearchText)
        {
            driver.FindElement(SearchElementField).SendKeys(SearchText);
            driver.FindElement(SearchElementField).SendKeys(Keys.Enter);
            return this;
        }
    }
}
