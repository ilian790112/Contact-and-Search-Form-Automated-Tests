using AutomationTests.Pages.BoogabooContactFormPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Models;
using System.IO;
using Configuration;
using AutomationTests.Pages.YavlenaSearchFormPage;
using System;
using System.Threading;

namespace AutomationTests
{
    [TestFixture]
    public class YavlenaSearchTests
    {

        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            //this.driver = new InternetExplorerDriver();
            this.driver = new ChromeDriver();
        }

        [Test]
        public void FillSearchFormWithoutCriteria()
        {

            var searchPage = new SearchFormPage(this.driver);

            searchPage.NavigateTo();
            searchPage.FillSearchFormWithoutCriteria();

            bool Status = driver.Url.Contains("properties/all/sofia");
            if (Status)
            {
                searchPage.AssertResultsTitle("Продажба");
            }

        }


        [Test]
        public void FillSearchFormWithInvalidLocationName()
        {

            var searchPage = new SearchFormPage(this.driver);
            Search search = AccessExcelData.GetSearchTestData("FillSearchFormWithInvalidLocationName");

            searchPage.NavigateTo();
            searchPage.FillSearchFormWithLocation(search);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            searchPage.AssertInvalidLocationInputErrorMessage("Неправилно изписване. Моля коригирайте и изберете от предложените варианти");
        }


        [Test]
        public void RentRoomInSofia()
        {

            var searchPage = new SearchFormPage(this.driver);
            Search search = AccessExcelData.GetSearchTestData("RentRoomInSofia");

            searchPage.NavigateTo();
            searchPage.RentRoomLocation(search);

            bool Status = driver.Url.Contains("properties/rentals/sofia");
            if (Status)
            {
                searchPage.AssertResultsTitle("Наем");
            }
                     
        }


        [Test]
        public void BuyOfficeInPlovdiv()
        {

            var searchPage = new SearchFormPage(this.driver);
            Search search = AccessExcelData.GetSearchTestData("BuyOffficeInPlovdiv");

            searchPage.NavigateTo();
            searchPage.BuyOfficeLocation(search);

            bool Status = driver.Url.Contains("properties/sales/plovdiv");
            if (Status)
            {
                searchPage.AssertResultsTitle("Продажба");
            }
            
        }



        [Test]
        public void BuyIndustrialPropertiesInVarna()
        {

            var searchPage = new SearchFormPage(this.driver);
            Search search = AccessExcelData.GetSearchTestData("BuyIndustrialPropertiesInVarna");

            searchPage.NavigateTo();
            searchPage.BuyIndustrialPropertiesLocation(search);

            bool Status = driver.Url.Contains("properties/sales/varna/?ptype=Warehouse,ManufacturingFacility,OtherIndustrialProperties");
            if (Status)
            {
                searchPage.AssertResultsTitle("Продажба");
            }

        }


        [Test]
        public void BuyAndRentAllResidentialPropertiesInGabrovo()
        {

            var searchPage = new SearchFormPage(this.driver);
            Search search = AccessExcelData.GetSearchTestData("BuyAndRentResidentialPropertiesInGabrovo");

            searchPage.NavigateTo();
            searchPage.BuyAndRentAllResidentialPropertiesLocation(search);

            bool Status = driver.Url.Contains("properties/all/gabrovo/gabrovo/?ptype=Room,Studio,OneBedroomApartment,TwoBedroomApartment,ThreeBedroomApartment,FourBedroomApartment,FivePlusBedroomApartment,House,HouseWholeFloor,GarageParking");
            if (Status)
            {
                searchPage.AssertResultsTitle("Продажба");
            }

        }


        [Test]
        public void BuyHouseInBlagoevgradAvramovo()
        {

            var searchPage = new SearchFormPage(this.driver);
            Search search = AccessExcelData.GetSearchTestData("BuyHouseInBlagoevgradAvramovo");

            searchPage.NavigateTo();
            searchPage.BuyIndustrialPropertiesLocation(search);

            bool Status = driver.Url.Contains("properties/sales/blagoevgrad/avramovo-village/?ptype=House");
            if (Status)
            {
                searchPage.AssertResultsTitle("Продажба");
            }

        }


        [Test]
        public void RentWarehouseInVarnaBoyana()
        {

            var searchPage = new SearchFormPage(this.driver);
            Search search = AccessExcelData.GetSearchTestData("RentWarehouseInVarnaBoyana");

            searchPage.NavigateTo();
            searchPage.RentWarehouseLocation(search);

            bool Status = driver.Url.Contains("properties/rentals/varna/boyana-village/?ptype=Warehouse");
            if (Status)
            {
                searchPage.AssertResultsTitle("Наем");
            }

        }


        [Test]
        public void SelectLocationUsingClicks()
        {

            var searchPage = new SearchFormPage(this.driver);

            searchPage.NavigateTo();
            searchPage.SelectLocationUsingClicks();

            searchPage.AssertResultsTitle("Наем > област Бургас > Айтос >");
        }


        [TearDown]
        public void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        " + TestContext.CurrentContext.WorkDirectory + "            " + TestContext.CurrentContext.Result.PassCount);

                var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
            }

            this.driver.Quit();

        }
    }
}
