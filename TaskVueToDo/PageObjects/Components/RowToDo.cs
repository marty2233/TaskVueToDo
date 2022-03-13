using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using TaskVueToDo.Helpers;

namespace TaskVueToDo.PageObjects.Components
{
    public class RowToDo
    {
        private readonly IWebDriver Driver;

        public RowToDo(IWebDriver driver, IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = ".toggle")]
        private IWebElement RowCheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".destroy")]
        private IWebElement RowDeleteBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = "label")]
        private IWebElement RowText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".edit")]
        private IWebElement RowEdit { get; set; }

        public string GetRowText => RowText.Text;
        public bool IsTheToDoCompleted => RowCheckBox.Selected;

        public void ClickCheckBox()
        {
            RowCheckBox.Click();

            if (IsTheToDoCompleted == true)
            {
                Driver.WaitUntilCssValueIsPresent(RowText, "text-decoration", "line-through");
            }

            if (IsTheToDoCompleted == false)
            {
                Driver.WaitUntilCssValueIsNotPresent(RowText, "text-decoration", "line-through");
            }
        }

        public void ClickDeleteBtn()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(RowText).Perform();
            Driver.WaitForElementVisible(RowDeleteBtn);
            RowDeleteBtn.Click();
            Driver.WaitElementToDisappear(RowDeleteBtn);
        }

        public void EditToDoWithName(string newName)
        {
            Actions action = new Actions(Driver);
            action.DoubleClick(RowText).Perform();

            RowEdit.SendKeys(Keys.Command + "a");
            RowEdit.SendKeys(newName);
            RowEdit.SendKeys(Keys.Enter);
        }
    }
}
