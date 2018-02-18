using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;


namespace AutomationTests.Pages.BoogabooContactFormPage
{
    public partial class ContactFormPage
    {     

        public IWebElement FirstName
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("_contactsupportpage_WAR_contactsupportpageportlet_firstName"));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("_contactsupportpage_WAR_contactsupportpageportlet_lastName"));
            }
        }

        public IWebElement Email
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("_contactsupportpage_WAR_contactsupportpageportlet_email"));
            }
        }


        private IWebElement ProductDD
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("_contactsupportpage_WAR_contactsupportpageportlet_product"));
            }
        }

        public SelectElement ProductOption
        {
            get
            {
                return new SelectElement(ProductDD);
            }
        }

        private IWebElement CategoryDD
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("_contactsupportpage_WAR_contactsupportpageportlet_category"));
            }
        }

        public SelectElement CategoryOption
        {
            get
            {
                return new SelectElement(CategoryDD);
            }
        }

        private IWebElement SubCategoryDD
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("_contactsupportpage_WAR_contactsupportpageportlet_subCategory"));
            }
        }

        public SelectElement SubCategoryOption
        {
            get
            {
                return new SelectElement(SubCategoryDD);
            }
        }


        public IWebElement Message
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("_contactsupportpage_WAR_contactsupportpageportlet_message"));
            }
        }

        public IWebElement UploadButton
        {
            get
            {
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"new_file_row[0]\"]/td/div/label[2]"));
            }
        }

       

        public IWebElement SendButton
        {
            get
            {
                return this.IWebDriver.FindElement(By.Id("submitBtn"));
            }
        }

        public IWebElement ThankYouMessage
        {
            get
            {
                return this.IWebDriver.FindElement(By.XPath("//*[@id=\"p_p_id_contactsupportpage_WAR_contactsupportpageportlet_\"]/div/div/div[2]/section/div/div/header/h2"));
            }
        }

        public IWebElement ErrorMessagesForFirstName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("firstNameError")));
                return this.IWebDriver.FindElement(By.Id("firstNameError"));
            }
        }

        public IWebElement ErrorMessagesForLastName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("lastNameError")));
                return this.IWebDriver.FindElement(By.Id("lastNameError"));
            }
        }

        public IWebElement ErrorMessagesForEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("emailError")));
                return this.IWebDriver.FindElement(By.Id("emailError"));
            }
        }

        public IWebElement ErrorMessagesForInvalidEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("errValidEmail")));
                return this.IWebDriver.FindElement(By.Id("errValidEmail"));
            }
        }

        public IWebElement ErrorMessageForProductType
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("select_product_Error")));
                return this.IWebDriver.FindElement(By.Id("select_product_Error"));
            }
        }

        public IWebElement ErrorMessageForCategory
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("select_Category_Error")));
                return this.IWebDriver.FindElement(By.Id("select_Category_Error"));
            }
        }

        public IWebElement ErrorMessageForSubCategory
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("select_SubCategory_Error")));
                return this.IWebDriver.FindElement(By.Id("select_Category_Error"));
            }
        }

        public IWebElement ErrorMessageForMessage
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("messageError")));
                return this.IWebDriver.FindElement(By.Id("messageError"));
            }

        }

            public IWebElement ErrorMessageForInvalidFileFormat
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("fileSizeError[0]")));
                return this.IWebDriver.FindElement(By.Id("fileSizeError[0]"));
            }
        }


    }
}
