using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kitchenlia_Funcationality_Test
{
    class HomePage
    {
        IWebDriver webDriver;

        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        public IWebElement lnkShop => Driver.FindElement(By.LinkText("Shop"));

        IWebElement txtShop => Driver.FindElement(By.XPath("//*[@id='item_mb_nav - 1']/a"));

        public void ClickShop() => lnkShop.Click();

        public IWebElement lnkContactus => Driver.FindElement(By.LinkText("Contact us"));

        public void ClickContactus() => lnkContactus.Click();

        public IWebElement lnkSearch => Driver.FindElement(By.LinkText("Search"));

        public void ClickSearch() => lnkSearch.Click();




    }



   






}
