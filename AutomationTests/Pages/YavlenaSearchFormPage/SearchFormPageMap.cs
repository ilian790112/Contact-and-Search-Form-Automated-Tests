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
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("buy-label")));
                return this.IWebDriver.FindElement(By.ClassName("buy-label"));
            }
        }


        public IWebElement Rent
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("rent-label")));
                return this.IWebDriver.FindElement(By.ClassName("rent-label"));
            }
        }


        public IWebElement TypeOfProperty
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".placeholder[placeholder='тип имот']")));
                return this.IWebDriver.FindElement(By.CssSelector(".placeholder[placeholder='тип имот']"));
            }
        }




        public IWebElement Room
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='Стая']")));
                return this.IWebDriver.FindElement(By.XPath("//label[text()='Стая']"));
            }
        }


        public IWebElement House
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='Къща']")));
                return this.IWebDriver.FindElement(By.XPath("//label[text()='Къща']"));
            }
        }




        public IWebElement Office
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='Офис']")));
                return this.IWebDriver.FindElement(By.XPath("//label[text()='Офис']"));
            }
        }


        public IWebElement IndustrialProperties
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[text()='Индустриални имоти']")));
                return this.IWebDriver.FindElement(By.XPath("//a[text()='Индустриални имоти']"));
            }
        }

        public IWebElement ResidentialProperties
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[text()='Жилищни имоти']")));
                return this.IWebDriver.FindElement(By.XPath("//a[text()='Жилищни имоти']"));
            }
        }

        public IWebElement Warehouse
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='Склад']")));
                return this.IWebDriver.FindElement(By.XPath("//label[text()='Склад']"));
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
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"searchBox\"]/following-sibling::a[1]")));
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"searchBox\"]/following-sibling::a[1]"));
            }
        }


        public IWebElement Burgas
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Бургас']")));
                return this.IWebDriver.FindElement(By.XPath("//span[text()='Бургас']"));
            }
        }

        public IWebElement Aitos
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Айтос']")));
                return this.IWebDriver.FindElement(By.XPath("//span[text()='Айтос']"));
            }
        }


        public IWebElement ButtonFind
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[@class='green-btn']")));
                return this.IWebDriver.FindElement(By.XPath("//button[@class='green-btn']"));
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
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("estates-breadcrumb")));
                return this.IWebDriver.FindElement(By.ClassName("estates-breadcrumb"));
            }
        }


    }
}
