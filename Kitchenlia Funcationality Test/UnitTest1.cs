using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading.Tasks;

namespace Kitchenlia_Funcationality_Test
{
    public class Tests
    {
        WebDriver webDriver = new ChromeDriver(@"C:\Users\DELL\Downloads\Driver");

        

       

        [SetUp]
        public void Setup()
        {
            


        }

        [Test]
        public void Test1()
        {

                        
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl("https://kitchenlia.com/");

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/header/div/div[2]/div/div/div/div[3]/nav/ul/li[2]/a")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/div[1]/div[2]/div[1]/a[1]")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/div[1]/div[2]/div[1]/a[2]")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/div[1]/div[2]/div[1]/a[3]")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/div[1]/div[2]/div[1]/a[4]")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/div[1]/div[2]/div[1]/a[5]")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/header/div/div[2]/div/div/div/div[3]/nav/ul/li[3]/a")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/header/div/div[2]/div/div/div/div[4]/div/a[1]/i")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[13]/div/div/form/div[1]/div/input")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[13]/div/div/form/i")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/header/div/div[2]/div/div/div/div[4]/div/a[2]/i")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/header/div/div[2]/div/div/div/div[4]/div/div[2]/a/i")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[9]/div/form/div[1]/i")).Click();

            Task.Delay(3000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[3]/header/div/div[2]/div/div/div/div[3]/nav/ul/li[1]/a")).Click();


        }



        [OneTimeTearDown]
        public void CloseTest()
        {
            Task.Delay(3000).Wait();
            webDriver.Close();
        }


    }

    
    
}