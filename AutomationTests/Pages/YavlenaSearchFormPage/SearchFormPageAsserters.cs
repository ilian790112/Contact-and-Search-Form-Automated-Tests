using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Pages.YavlenaSearchFormPage
{
    public static class SearchFormPageAsserter
    {

        public static void AssertResultsTitle(this SearchFormPage page, string text)
        {
            
            Assert.IsTrue(page.ResultsTitle.Displayed);
            StringAssert.Contains(text, page.ResultsTitle.Text);
        }

        public static void AssertInvalidLocationInputErrorMessage(this SearchFormPage page, string text)
        {
            Assert.IsTrue(page.LocationInvalidInputError.Displayed);
            StringAssert.Contains(text, page.LocationInvalidInputError.Text);
        }


    }
}
