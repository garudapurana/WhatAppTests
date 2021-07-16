using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;


namespace WhatAppTests
{
    public class AppManager
    {
        public IWebDriver driver;
     

        public void Login(User user)
        {
            Type(By.Id("email"), user.GetEmail());
            Type(By.Id("password"), user.GetPass());
            Click(By.CssSelector(".btn"));
        }

        public void Logout()
        { 
            Click(By.CssSelector(".header__header__account-user--fullname___2kSON"));
            Click(By.LinkText("Log Out"));
        }

        private void Click(By locator)
        {
            driver.FindElement(locator).Click();
        }

        private void Type(By locator, string text)
        {
            driver.FindElement(locator).Click();
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }
        public void Init()
        {
            driver = new ChromeDriver();
            
            driver.Manage().Window.Size = new System.Drawing.Size(1351, 856);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //string url = "https://gentle-moss-0bbec9003.azurestaticapps.net";
            string url1 = "http://localhost:8080/";

            driver.Navigate().GoToUrl(url1);
        }
        public void Stop()
        {
            driver.Quit();
        }
    }
}