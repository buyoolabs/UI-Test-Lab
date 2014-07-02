using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Buyoo.UITest.PageObjectsTest.PageObjects
{
    public class SearchPage : Page
    {
        public SearchPage SelectCategory(string category)
        {
            this.Find
                .Element(By.LinkText(category))
                .Click();
            return this;
        }

        //public HomePage InputSearchTerm(string category)
        //{
        //    this.Find.Element(By.Name("q"))
        //        .SendKeys(term);
        //    return this;
        //}

        public bool ExistsResults()
        {
            try
            {
                this.Find.Element(By.XPath("//article[@class='Wall']"));
                return true;
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                return false;
            }
        }

        public SearchPage Search()
        {
            return this.Navigate.To<SearchPage>(By.Id("search-button"));
        }
    }
}
