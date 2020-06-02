using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmagProject.PageObjects
{
    class WashMachinePage : PageObject
    {
        public IWebElement OrderBy => WebDriver.FindElement(By.XPath("//*[@id=\"main-container\"]/section[1]/div/div[3]/div[2]/div[2]/div[6]/div/div[2]/div[1]"));
        //sort-control-btn-dropdown hidden-xs
        //btn btn-sm btn-alt sort-control-btn
        //sort-control-btn-title
        //*[@id=\"main-container\"]/section[1]/div/div[3]/div[2]/div[2]/div[6]/div/div[2]/div[1]
        //*[@id=\"main-container\"]/section[1]/div/div[3]/div[2]/div[2]/div[6]/div/div[2]/div[1]/button
        //*[@id=\"main-container\"]/section[1]/div/div[3]/div[2]/div[2]/div[6]/div/div[2]/div[1]/button/span[1]

        public IList<IWebElement> Brands => WebDriver.FindElements(By.ClassName("js-filter-item filter-item"));
        //js-filter-item filter-item
        //filter-body filter-min-fixed js-scrollable

        public void AddWashMachines(string orderBy, List<string> brands, int nrOfItems)
        {
            Assert.IsTrue(OrderBy != null);
            //if (orderBy != String.Empty)
            //*new SelectElement(OrderBy).SelectByText(orderBy);

            //*IWebElement Brand = WebDriver.FindElement(By.Name("Samsung"));
            //*IWebElement Brand = WebDriver.FindElement(By.LinkText("Samsung"));
            //*Assert.IsTrue(Brand != null);

            //*Assert.IsTrue(Brands != null);
            //for (int i = 0; i < Brands.Count; i++)
            //{
            //*    String Value = Brands.ElementAt(i).GetAttribute("value");

            //    foreach (var brand in brands)
            //    {
            //        if (Value.Equals(brand))
            //        {
            //*            Brands.ElementAt(i).Click();
            //        }
            //    }
            //}

            //*IList<IWebElement> washMachinesToAdd = WebDriver.FindElements(By.ClassName("btn btn-sm btn-primary btn-emag yeahIWantThisProduct"));
            //for (var i = 0; i < nrOfItems; i++)
            //{
            //*    washMachinesToAdd.ElementAt(i).Click();
            //}
        }
    }
}
