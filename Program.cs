using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace switchTab
{
    class Program
    {
        static void Main()
        {
            List<string> handles = new List<string>();

            IWebDriver driver = new ChromeDriver();
            IWebElement newTab;
            IWebElement newWindow;

            string url = "https://testing.todorvachev.com/tabs-and-windows/new-tab/";
            string newTabSelector = "#post-182 > div > p:nth-child(1) > a:nth-child(1)";
            string newWindowSelector = "#post-182 > div > p:nth-child(1) > a:nth-child(3)";

            driver.Navigate().GoToUrl(url);

            newTab = driver.FindElement(By.CssSelector(newTabSelector));
            newWindow = driver.FindElement(By.CssSelector(newWindowSelector));

            newTab.Click();
            handles = driver.WindowHandles.ToList();

            for (int i = 0; i < handles.Count; i++)
            {
                System.Console.WriteLine(handles[i]);
            }

            IWebElement searchBox = driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(2) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input"));
            searchBox.SendKeys("Selenium");
        }
    }
}
