using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    class HomePrintersPageObject
    {
        private IWebDriver driver;
        private Actions action;

        private readonly By SearchFilterButton = By.XPath("//button[@class='pl-more-button collapsed product-filter-toggle']");
        private readonly By ColorCheckbox = By.XPath("//label[text()='Цветной']");
        private readonly By SearchResultButton = By.XPath("//input[@name='apply']");

        public HomePrintersPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public HomePrintersPageObject SearchFilterClick()
        {
            action.MoveToElement(driver.FindElement(SearchFilterButton)).Click();
            action.Perform();
            return this;
        }

        public HomePrintersPageObject ColorCheckboxClick()
        {
            driver.FindElement(ColorCheckbox).Click();            
            return this;
        }

        public HomePrintersPageObject SearchRelustClick()
        {
            action.MoveToElement(driver.FindElement(SearchResultButton)).Click();
            action.Perform();
            return this;
        }
    }
}
