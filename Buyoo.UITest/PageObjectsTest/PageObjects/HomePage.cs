using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;

namespace Buyoo.UITest.PageObjectsTest.PageObjects
{
    public enum Category
    {
        AllDepartments = 1,
        AmazonInstantVideo = 2,
        Appliances = 3,
        AppsForAndroid = 4,
        ArtsCraftsAndSewing = 5,
        Automotive = 6
    }

    public class HomePage:Page
    {
        public HomePage SelectCategory(Category category)
        {
            this.Find.Element(By.Id("departmentButton")).Click();
            this.Find.Element(By.CssSelector(string.Format("li[value=\"{0}\"] > label", (int)category))).Click();

            return this;
        }

        //public HomePage InputSearchTerm(string category)
        //{
        //    this.Find.Element(By.Name("q"))
        //        .SendKeys(term);
        //    return this;
        //}

        public SearchPage Search()
        {
            return this.Navigate.To<SearchPage>(By.Id("search-button"));
        }      
    }
}
