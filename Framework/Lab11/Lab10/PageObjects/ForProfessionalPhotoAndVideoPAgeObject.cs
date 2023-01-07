using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    public class ForProfessionalPhotoAndVideoPAgeObject
    {
        private const string BASE_URL = "https://www.canon.ru/pro/";

        private IWebDriver driver;
        private Actions action;

        private readonly By ProductElementMenu = By.XPath("//a[@class='nav__menu-link canon-color--white canon-paragraph--medium']");
        private readonly By ProectorsElementMenu = By.LinkText("Проекторы");
        private readonly By OtherProductsElementMenu = By.LinkText("Другие Продукты");
        private readonly By BinoclesElementMenu = By.LinkText("Бинокли");

        public ForProfessionalPhotoAndVideoPAgeObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
        }

        public void ClickProectorsElement()
        {
            action.MoveToElement(driver.FindElement(ProductElementMenu));
            action.Perform();
            driver.FindElement(ProectorsElementMenu).Click();
        }

        public void HoverOtherProductsElement()
        {
            action.MoveToElement(driver.FindElement(ProductElementMenu));
            action.Perform();
            action.MoveToElement(driver.FindElement(OtherProductsElementMenu)).Click();
            action.Perform();
        }

        public void ClickBinocles()
        {
            driver.FindElement(BinoclesElementMenu).Click();
            
        }
    }
}
