using OpenQA.Selenium;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace AutomationTests.Pages.YavlenaSearchFormPage
{
    public partial class SearchFormPage : BasePage
    {
        public SearchFormPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.IWebDriver.Navigate().GoToUrl("https://www.yavlena.com/");
            
        }

        public void FillSearchFormWithoutCriteria()
        {
            this.ButtonFind.Click();
        }


        public void FillSearchFormWithLocation(Search search)
        {
            Type(this.Location, search.Location);
            this.ButtonFind.Click();
        }


        public void RentRoomLocation(Search search)
        {
            this.Service.Click();
            this.Buy.Click();
            this.TypeOfProperty.Click();
            this.Room.Click();
            Type(this.Location, search.Location);
            this.ButtonFind.Click();
        }


        public void BuyOfficeLocation(Search search)
        {
            this.Service.Click();
            this.Rent.Click();
            this.TypeOfProperty.Click();
            this.Office.Click();
            Type(this.Location, search.Location);
            this.ButtonFind.Click();
        }


        public void BuyIndustrialPropertiesLocation(Search search)
        {
            this.Service.Click();
            this.Rent.Click();
            this.TypeOfProperty.Click();
            this.IndustrialProperties.Click();
            Type(this.Location, search.Location);
            this.ButtonFind.Click();
        }


        public void BuyAndRentAllResidentialPropertiesLocation(Search search)
        {
            this.Service.Click();
            this.TypeOfProperty.Click();
            this.ResidentialProperties.Click();
            Type(this.Location, search.Location);
            this.ButtonFind.Click();
        }

        public void BuyHouseLocation(Search search)
        {
            this.Service.Click();
            this.Rent.Click();
            this.TypeOfProperty.Click();
            this.House.Click();
            Type(this.Location, search.Location);
            this.ButtonFind.Click();
        }

        public void RentWarehouseLocation(Search search)
        {
            this.Service.Click();
            this.Buy.Click();
            this.TypeOfProperty.Click();
            this.Warehouse.Click();
            Type(this.Location, search.Location);
            this.ButtonFind.Click();
        }



        public void SelectLocationUsingClicks()
        {
            this.Service.Click();
            this.Buy.Click();
            this.TypeOfProperty.Click();
            this.House.Click();
            this.Region.Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            this.Burgas.Click();
            this.Aitos.Click();
            this.ButtonFind.Click();
        }




        private void Type(IWebElement element, string text)
        {
            element.Clear();

            if (!text.Equals("String.Empty"))
            {
                element.SendKeys(text);
            }

            if (text.Equals("String.Empty"))
            {
                element.SendKeys("");
            }
        }
    }
}
