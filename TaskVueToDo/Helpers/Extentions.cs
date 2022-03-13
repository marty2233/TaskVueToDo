using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TaskVueToDo.Helpers
{
    public static class Extensions
    {
        /// <summary>
        /// Wait for a element to be displayed
        /// </summary>
        /// <param name="driver">webDriver as extension</param>
        /// <param name="element">Selenium IWebelement to wait</param>
        public static void WaitForElementVisible(this IWebDriver driver, IWebElement element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(drv => element.Displayed);
        }

        /// <summary>
        /// Wait for a element to not be visible anymore
        /// </summary>
        /// <param name="driver">webDriver as extension</param>
        /// <param name="element">Selenium IWebelement to wait</param>
        public static void WaitElementToDisappear(this IWebDriver driver, IWebElement element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(drv => !element.Exist());
        }

        /// <summary>
        /// Wait for a element to not be visible anymore
        /// </summary>
        /// <param name="driver">webDriver as extension</param>
        /// <param name="element">Selenium IWebelement to wait</param>
        /// <param name="time">Time to wait for element</param>
        public static void WaitElementToDisappear(this IWebDriver driver, IWebElement element, TimeSpan time)
        {
            new WebDriverWait(driver, time).Until(drv => !element.Exist());
        }

        /// <summary>
        /// Wait for a element to exits
        /// </summary>
        /// <param name="driver">webDriver as extension</param>
        /// <param name="element">Selenium IWebelement to wait</param>
        /// <returns>Returns whether the element exists or not</returns>

        public static bool WaitElementToExists(this IWebDriver driver, IWebElement element)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(drv => !element.Exist());
        }

        /// <summary>
        /// Return element existence depending on different values
        /// </summary>
        /// <returns><c>true</c> if element is Displayed and Width and Height is more than 0 or <c>false</c> otherwise.</returns>
        /// <param name="element">Element</param>
        public static bool Exist(this IWebElement element)
        {
            try
            {
                return element.Displayed & element.Size.Width > 0 & element.Size.Height > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Wait for a css value to be present in an element
        /// </summary>
        /// <param name="driver">webDriver as extension</param>
        /// <param name="element">IWebElement to wait</param>
        /// <param name="cssValue">Css value of the element</param>
        /// <param name="expectedValue">Expected css value</param>
        public static void WaitUntilCssValueIsPresent(this IWebDriver driver, IWebElement element, string cssValue, string expectedValue)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => element.GetCssValue(cssValue).Contains(expectedValue));
        }

        /// <summary>
        /// Wait for a css value to not be presented in an element
        /// </summary>
        /// <param name="driver">webDriver as extension</param>
        /// <param name="element">IWebElement to wait</param>
        /// <param name="cssValue">Css value of the element</param>
        /// <param name="expectedValue">Expected css value</param>
        public static void WaitUntilCssValueIsNotPresent(this IWebDriver driver, IWebElement element, string cssValue, string expectedValue)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => !element.GetCssValue(cssValue).Contains(expectedValue));
        }

    }
}