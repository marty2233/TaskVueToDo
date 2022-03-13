using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using TaskVueToDo.PageObjects.Components;
using TaskVueToDo.Helpers;

namespace TaskVueToDo.PageObjects
{
    public class VuePage
    {
        //The Selenium web driver to automate the browser
        private readonly IWebDriver Driver;

        public VuePage(IWebDriver webDriver)
        {
            Driver = webDriver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".new-todo")]
        private IWebElement ToDoField { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".todo-count > strong")]
        private IWebElement ToDoActiveCount { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".filters a[href^='#/active']")]
        private IWebElement ActiveButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".filters a[href^='#/all']")]
        private IWebElement AllButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".filters a[href^='#/completed']")]
        private IWebElement CompletedButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".clear-completed")]
        private IWebElement ClearAllCompletedButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".footer")]
        private IWebElement Footer { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".todo")]
        private IList<IWebElement> ToDoContainer { get; set; }
        [FindsBy(How = How.CssSelector, Using = "li a")]
        private IList<IWebElement> AllFilters { get; set; }
        [FindsBy(How = How.CssSelector, Using = "label[for='toggle-all']")]
        private IWebElement ToggleAll { get; set; }

        public IList<RowToDo> RowsToDo => ToDoContainer.Select(p => new RowToDo(Driver, p)).ToList();

        public bool ClearAllBtnDisplayed => ClearAllCompletedButton.Displayed;
        public string GetToDoCountText => ToDoActiveCount.Text;
        public bool IsTheAllBtnSelected => AllButton.Get().HasClass("selected");
        public bool IsTheCompletedBtnSelected => CompletedButton.Get().HasClass("selected");
        public bool IsTheActiveBtnSelected => ActiveButton.Get().HasClass("selected");
        public bool AreAllToDosCompleted => RowsToDo.All(p => p.IsTheToDoCompleted);
        public bool IsTheFooterDisplayed => Footer.Displayed;
        public string GetToDoFieldText => ToDoField.GetAttribute("placeholder");

        public RowToDo GetRowWithText(string title)
        {
            if (!RowsToDo.Any(x => x.GetRowText == title))
            {
                throw new System.Exception($"No such Todo {title}");
            }
            return RowsToDo.First(x => x.GetRowText == title);
        }

        public IList<string> GetAllToDosText()
        {
            return ToDoContainer.Select(x => x.Text).ToList();
        }

        public int GetToDoCount()
        {
            int toDosCount = RowsToDo.Count;
            return toDosCount;
        }

        public void NavigateToHomePage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Url"]);
            Driver.WaitForElementVisible(ToDoField);
        }

        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
            Driver.WaitForElementVisible(ToDoField);
        }

        public void AddNewToDo(string text)
        {
            ToDoField.SendKeys(text);
            ToDoField.SendKeys(Keys.Enter);
        }

        public void ClickActiveBtn()
        {
            ActiveButton.Click();
        }

        public void ClickAllBtn()
        {
            AllButton.Click();
        }

        public void ClickCompletedBtn()
        {
            CompletedButton.Click();
        }

        public void ClickClearAllCompletedButton()
        {
            ClearAllCompletedButton.Click();
        }

        public void ClickToggleAllButton()
        {
            ToggleAll.Click();
        }

        public string GetActiveFilter()
        {
            return AllFilters.First(p => p.Get().HasClass("selected")).Text;
        }
    }
}