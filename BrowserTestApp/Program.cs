using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace BrowserTestApp
{
    class Program
    {
      
        static void Main(string[] args)
        {

            //For FireFox
           // seleniumScript(new FirefoxDriver());

            //For Chrome
            seleniumScript(new ChromeDriver());

        }


        public static void seleniumScript(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement input = driver.FindElement(By.Name("q"));
            input.SendKeys(".Net Test Automation");
            Thread.Sleep(2000);
            IWebElement btn = driver.FindElement(By.Name("btnK"));
            btn.Click();
            driver.Close();
           

        }
    }
}
