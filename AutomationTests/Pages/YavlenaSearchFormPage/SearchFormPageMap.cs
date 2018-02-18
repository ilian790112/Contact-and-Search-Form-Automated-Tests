using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AutomationTests.Pages.YavlenaSearchFormPage
{
    public partial class SearchFormPage
    {     

        

        public IWebElement Service
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("serviceChoice"));
            }

        }


        public IWebElement Buy
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"serviceChoice\"]/div[2]/div/div/ul/li/label[1]/span")));
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"serviceChoice\"]/div[2]/div/div/ul/li/label[1]/span"));
            }
        }


        public IWebElement Rent
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"serviceChoice\"]/div[2]/div/div/ul/li/label[2]/span")));
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"serviceChoice\"]/div[2]/div/div/ul/li/label[2]/span"));
            }
        }


        public IWebElement TypeOfProperty
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[1]/a")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[1]/a"));
            }
        }




        public IWebElement Room
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[1]/div/label[1]/div")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[1]/div/label[1]/div"));
            }
        }


        public IWebElement House
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[1]/div/label[8]/div")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[1]/div/label[8]/div"));
            }
        }




        public IWebElement Office
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[2]/div/label[1]/div")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[2]/div/label[1]/div"));
            }
        }


        public IWebElement IndustrialProperties
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[3]/a")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[3]/a"));
            }
        }

        public IWebElement ResidentialProperties
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[1]")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[1]"));
            }
        }

        public IWebElement Warehouse
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[3]/div/label[1]/div")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[2]/div/div[2]/div/div/ul/li[3]/div/label[1]/div"));
            }
        }




        public IWebElement Location
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"searchBox\"]")));
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"searchBox\"]"));
            }
        }



        public IWebElement Region
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[3]/div/div[1]/a")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[3]/div/div[1]/a"));
            }
        }


        public IWebElement Burgas
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"districts-list\"]/div/div/label[4]/div/ins")));
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"districts-list\"]/div/div/label[4]/div/ins"));
            }
        }

        public IWebElement Aitos
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"locations-list\"]/div/label[1]/div/ins")));
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"locations-list\"]/div/label[1]/div/ins"));
            }
        }


        public IWebElement ButtonFind
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section/div/form/div[4]/button")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section/div/form/div[4]/button"));
            }
        }


        public IWebElement LocationInvalidInputError
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"searchBox-validation\"]")));
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"searchBox-validation\"]"));
            }
        }

        public IWebElement ResultsTitle
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/section[2]/div/div[1]/div/aside/div/div[1]/span")));
                return this.IWebDriver.FindElement(By.XPath("/html/body/div[2]/div/section[2]/div/div[1]/div/aside/div/div[1]/span"));
            }
        }


    }
}
