using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTests
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void TestInteractionsAndVisibility()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com");

            // Метод для стабільного отримання елемента з повторною спробою
            IWebElement GetElement(By locator)
            {
                for (int attempt = 0; attempt < 3; attempt++)
                {
                    try
                    {
                        return wait.Until(ExpectedConditions.ElementIsVisible(locator));
                    }
                    catch (StaleElementReferenceException)
                    {
                        // Повторити спробу отримання елемента
                    }
                }
                throw new Exception("Не вдалося отримати актуальний елемент після кількох спроб.");
            }

            // Взаємодія з першими трьома елементами з поверненням на попередню сторінку
            var element1 = GetElement(By.XPath("/html/body/div[5]/div/div[2]/div/div[1]/div/div/h4/a"));
            element1.Click();
            driver.Navigate().Back(); 

            var element2 = GetElement(By.XPath("/html/body/div[5]/div/div[2]/div/div[2]/div/div/h4/a"));
            element2.Click();
            driver.Navigate().Back(); 

            var element3 = GetElement(By.XPath("/html/body/div[5]/div/div[2]/div/div[3]/div/div/h4/a"));
            element3.Click();
            driver.Navigate().Back(); 

            // Перевірка видимості елементів після повернення
            Assert.IsTrue(element1.Displayed, "Елемент 1 не відображається");
            Assert.IsTrue(element2.Displayed, "Елемент 2 не відображається");
            Assert.IsTrue(element3.Displayed, "Елемент 3 не відображається");
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
