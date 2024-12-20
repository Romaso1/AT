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

            // ����� ��� ���������� ��������� �������� � ��������� �������
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
                        // ��������� ������ ��������� ��������
                    }
                }
                throw new Exception("�� ������� �������� ���������� ������� ���� ������ �����.");
            }

            // ������� � ������� ������ ���������� � ����������� �� ��������� �������
            var element1 = GetElement(By.XPath("/html/body/div[5]/div/div[2]/div/div[1]/div/div/h4/a"));
            element1.Click();
            driver.Navigate().Back(); 

            var element2 = GetElement(By.XPath("/html/body/div[5]/div/div[2]/div/div[2]/div/div/h4/a"));
            element2.Click();
            driver.Navigate().Back(); 

            var element3 = GetElement(By.XPath("/html/body/div[5]/div/div[2]/div/div[3]/div/div/h4/a"));
            element3.Click();
            driver.Navigate().Back(); 

            // �������� �������� �������� ���� ����������
            Assert.IsTrue(element1.Displayed, "������� 1 �� ������������");
            Assert.IsTrue(element2.Displayed, "������� 2 �� ������������");
            Assert.IsTrue(element3.Displayed, "������� 3 �� ������������");
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
