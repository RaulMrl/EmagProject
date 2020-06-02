using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmagProject.PageObjects
{
    class HomePage : PageObject
    {
        public IWebElement HouseProducts => WebDriver.FindElement(By.LinkText("Electrocasnice & Climatizare"));

        public IWebElement MyChart => WebDriver.FindElement(By.Id("my_cart"));

        public IWebElement CheckElement => WebDriver.FindElement(By.ClassName("title-phrasing title-phrasing-xl"));

        public void GoToWashMachines()
        {
            this.WebDriver.Url = "https://www.emag.ro/masini-spalat-rufe/filter/tip-incarcare-f7953,frontala-v-1732451/c?ref=hp_menu_quick-nav_267_6&type=filter";
            //Actions action = new Actions(this.WebDriver);
            //action.MoveToElement(HouseProducts).Perform();

            //WebDriverWait wait = new WebDriverWait(this.WebDriver, TimeSpan.FromSeconds(10));

            //IWebElement WashMachineWithFrontCharge = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Incarcare frontala")));

            //action.MoveToElement(WashMachineWithFrontCharge).Click().Build().Perform();
        }

        public void GoToMyChart()
        {
            MyChart.Click();
        }

        public string TakeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot) this.WebDriver).GetScreenshot();
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm");
            string filePathAndName = @"C:\Users\rmerlan\Documents\EmagTest\Screenshots\" + timestamp + ".png";
            ss.SaveAsFile(filePathAndName , ScreenshotImageFormat.Png);
            return filePathAndName;
        }

        public void CheckScreenShot(string filePathAndName)
        {
            Assert.IsTrue(File.Exists(filePathAndName));
        }
    }
}
