using AutomationTests.Pages.BoogabooContactFormPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Models;
using System.IO;
using Configuration;

namespace AutomationTests
{
    [TestFixture]
    public class BoogabooFormTests
    {

        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            //this.driver = new InternetExplorerDriver();
            this.driver = new ChromeDriver();
        }

        [Test]
        public void FillContactFormWithOutFirstName()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithOutFirstName");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertFirstNameErrorMessage("Please enter your first name");
        }


        [Test]
        public void FillContactFormWithOutLastName()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithOutLastName");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertLastNameErrorMessage("Please enter your last name");
        }

        [Test]
        public void FillContactFormWithOutEmail()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithOutEmail");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertEmailErrorMessage("Please enter your e-mail address");
        }

        [Test]
        public void FillContactFormWithOutProductSelected()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithOutProductSelected");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertProductErrorMessage("Please select a product type");
        }

        [Test]
        public void FillContactFormWithOutCategorySelected()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithOutCategorySelected");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertCategoryErrorMessage("Please select your category");
        }

        [Test]
        public void FillContactFormWithOutSubCategorySelected()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithOutSubCategorySelected");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertSubCategoryErrorMessage("Please select your sub-category");
        }

        [Test]
        public void FillContactFormWithOutMessage()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithOutMessage");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertMessageErrorMessage("Please enter your message");
        }

        [Test]
        public void FillContactFormWithInvalidEmail()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormWithInvalidEmail");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertInvalidEmailErrorMessage("Please enter a valid e-mail address");
        }

        [Test]
        public void FillContactFormInvalidFileFormat()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("FillContactFormInvalidFileFormat");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);

            contactPage.AssertInvalidFileFormatErrorMessage("Unable to upload the file. Only Jpeg, jpg, doc, docx, pdf, txt, png files supported.");
        }

        [Test]
        public void SuccessfullRegistration()
        {

            var contactPage = new ContactFormPage(this.driver);
            User user = AccessExcelData.GetUserTestData("Successfull registration");

            contactPage.NavigateTo();
            contactPage.FillContactForm(user);
            contactPage.SendButton.Click();

            contactPage.AssertSuccessMessage("Thank you");
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
