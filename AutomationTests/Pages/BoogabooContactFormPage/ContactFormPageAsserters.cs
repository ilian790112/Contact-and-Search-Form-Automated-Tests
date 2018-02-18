using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Pages.BoogabooContactFormPage
{
    public static class ContactFormPageAsserter
    {

        public static void AssertSuccessMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ThankYouMessage.Displayed);
            Assert.AreEqual(text, page.ThankYouMessage.Text);
        }

        public static void AssertFirstNameErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForFirstName.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForFirstName.Text);
        }

        public static void AssertLastNameErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForLastName.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForLastName.Text);
        }

        public static void AssertEmailErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForEmail.Text);
        }

        public static void AssertInvalidEmailErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForInvalidEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForInvalidEmail.Text);
        }

        public static void AssertProductErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForProductType.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForProductType.Text);
        }

        public static void AssertCategoryErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForCategory.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForCategory.Text);
        }

        public static void AssertSubCategoryErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForSubCategory.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForSubCategory.Text);
        }

        public static void AssertMessageErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForMessage.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForMessage.Text);
        }

        public static void AssertInvalidFileFormatErrorMessage(this ContactFormPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalidFileFormat.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForInvalidFileFormat.Text);
        }


    }
}
