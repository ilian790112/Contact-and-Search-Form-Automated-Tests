using OpenQA.Selenium;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTests.Pages.BoogabooContactFormPage
{
    public partial class ContactFormPage : BasePage
    {
        public ContactFormPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.IWebDriver.Navigate().GoToUrl("https://www.bugaboo.com/US/en_US/support/contact-support/");
        }

        public void FillContactForm(User user)
        {
            Type(this.FirstName, user.FirstName);
            Type(this.LastName, user.LastName);
            Type(this.Email, user.Email);
            this.ProductOption.SelectByText(user.Product);
            this.CategoryOption.SelectByText(user.Category);

            if (user.Category != "Please select your category")
            {
                this.SubCategoryOption.SelectByText(user.SubCategory);
            }

            Type(this.Message, user.Message);
            this.UploadButton.Click();
            this.IWebDriver.SwitchTo().ActiveElement().SendKeys("@" + user.File);

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
