using EmagProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmagProject.Tests
{
    class BuyWashMachinesTest
    {
        public HomePage HomePage;
        public WashMachinePage WashMachinePage;

        [SetUp]
        public void Initialize()
        {
            HomePage = new HomePage();
            WashMachinePage = new WashMachinePage();

            HomePage.WebDriver = new ChromeDriver();
            HomePage.WebDriver.Url = "https://www.emag.ro/";
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void BuyWashMachines()
        {
            HomePage.GoToWashMachines();
            WashMachinePage.WebDriver = HomePage.WebDriver;
            List<string> brands = new List<string>();
            brands.Add("Whirlpool");
            brands.Add("Samsung");
            WashMachinePage.AddWashMachines("Pret crescator", brands, 5);
            HomePage.WebDriver = WashMachinePage.WebDriver;
            HomePage.GoToMyChart();
            string filePathAndName = HomePage.TakeScreenShot();
            HomePage.CheckScreenShot(filePathAndName);
        }

        [TearDown]
        public void CleanUp()
        {
            HomePage.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}
