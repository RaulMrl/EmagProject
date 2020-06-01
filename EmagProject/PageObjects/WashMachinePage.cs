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
        public IWebElement OrderBy => WebDriver.FindElement(By.ClassName("btn btn-sm btn-alt sort-control-btn"));
        public IList<IWebElement> Brands => WebDriver.FindElements(By.ClassName("js-filter-item filter-item"));

        public void AddWashMachines(string orderBy, List<string> brands, int nrOfItems)
        {
            if (orderBy != String.Empty)
                new SelectElement(OrderBy).SelectByText(orderBy);

            for (int i = 0; i < Brands.Count; i++)
            {
                String Value = Brands.ElementAt(i).GetAttribute("value");

                foreach (var brand in brands)
                {
                    if (Value.Equals(brand))
                    {
                        Brands.ElementAt(i).Click();
                    }
                }
            }

            IList<IWebElement> washMachinesToAdd = WebDriver.FindElements(By.ClassName("btn btn-sm btn-primary btn-emag yeahIWantThisProduct"));
            for (var i = 0; i < nrOfItems; i++)
            {
                washMachinesToAdd.ElementAt(i).Click();
            }
        }
    }
}
