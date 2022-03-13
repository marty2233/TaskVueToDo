using System;
using TechTalk.SpecFlow;
using TaskVueToDo.PageObjects;
using NUnit.Framework;
using TaskVueToDo.Helpers;

namespace TaskVueToDo.Steps
{
    [Binding]
    public class VueSteps
    {
        private readonly VuePage vuePage;

        public VueSteps(BrowserDriver browserDriver)
        {
            vuePage = new VuePage(browserDriver.Current);
        }

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            vuePage.NavigateToHomePage();
        }

        [When(@"I refresh the page")]
        public void WhenIRefreshThePage()
        {
            vuePage.RefreshPage();
        }

        [StepDefinition(@"the active items count is ""(.*)""")]
        public void ThenTheActiveItemsCountIs(string num)
        {
            Assert.AreEqual(num, vuePage.GetToDoCountText);
        }

        [Then(@"the ""(.*)"" filter is displayed as selected")]
        public void ThenTheFilterIsDisplayedAsSelected(string filter)
        {
            switch (filter.ToLower())
            {
                case "all":
                    {
                        Assert.That(vuePage.IsTheAllBtnSelected, "The selected filter is " + vuePage.GetActiveFilter());
                        break;
                    }
                case "active":
                    {
                        Assert.That(vuePage.IsTheActiveBtnSelected, "The selected filter is " + vuePage.GetActiveFilter());
                        break;
                    }
                case "completed":
                    {
                        Assert.That(vuePage.IsTheCompletedBtnSelected, "The selected filter is " + vuePage.GetActiveFilter());
                        break;
                    }
                default:
                    {
                        throw new Exception($"Filter {filter} not found!");
                    }
            }
        }

        [StepDefinition(@"I mark ""(.*)"" as completed")]
        public void WhenIMarkAsCompleted(string text)
        {
            vuePage.GetRowWithText(text).ClickCheckBox();
            Assert.IsTrue(vuePage.GetRowWithText(text).IsTheToDoCompleted, "The status of the todo is not as expected!");
        }

        [When(@"I uncomplete ""(.*)""")]
        public void WhenIUncomplete(string text)
        {
            vuePage.GetRowWithText(text).ClickCheckBox();
            Assert.IsFalse(vuePage.GetRowWithText(text).IsTheToDoCompleted, "The status of the todo is not as expected!");
        }
        
        [StepDefinition(@"I click on the ""(.*)"" filter button")]
        public void WhenIClickOnTheFilterButton(string btnName)
        {
            switch (btnName.ToLower())
            {
                case "all":
                    {
                        vuePage.ClickAllBtn();
                        break;
                    }
                case "active":
                    {
                        vuePage.ClickActiveBtn();
                        break;
                    }
                case "completed":
                    {
                        vuePage.ClickCompletedBtn();
                        break;
                    }
                default:
                    {
                        throw new Exception($"Filter button {btnName} not found!");
                    }
            }
        }

        [StepDefinition(@"Verify To Do count in the list is ""(.*)""")]
        public void ThenVerifyToDoCountInTheListIs(int number)
        {
            Assert.AreEqual(number, vuePage.GetToDoCount());
        }

        [StepDefinition(@"I click on the Clear Completed button")]
        public void WhenIClickOnTheClearCompletedButton()
        {
            vuePage.ClickClearAllCompletedButton();
        }

        [StepDefinition(@"the Clear completed button is not displayed")]
        public void GivenTheClearCompletedButtonIsNotDisplayed()
        {
            Assert.IsFalse(vuePage.ClearAllBtnDisplayed, "The Clear completed button is Displayed!");
        }

        [StepDefinition(@"I add a ToDo")]
        public void WhenIAddAToDo(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                vuePage.AddNewToDo(row["ToDoName"]);
            }
        }

        [Then(@"Verify the following todos are displayed in the list")]
        public void ThenVerifyTheFollowingTodosAreDisplayedInTheList(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                Assert.That(vuePage.GetAllToDosText, Has.Member(row["ToDoName"]));
            }
        }

        [StepDefinition(@"I delete the ToDo with name ""(.*)""")]
        public void WhenIDeleteTheToDoWithName(string text)
        {
            vuePage.GetRowWithText(text).ClickDeleteBtn();
        }

        [StepDefinition(@"I edit a ToDo with name ""(.*)"" to ""(.*)""")]
        public void WhenIEditAToDoWithNameTo(string oldName, string newName)
        {
            vuePage.GetRowWithText(oldName).EditToDoWithName(newName);
        }

        [StepDefinition(@"Verify the todo ""(.*)"" is displayed in the list")]
        public void ThenVerifyTheTodoIsDisplayedInTheList(string name)
        {
            Assert.That(vuePage.GetAllToDosText, Has.Member(name));
        }

        [StepDefinition(@"Verify the todo ""(.*)"" is not displayed in the list")]
        public void ThenVerifyTheTodoIsNotDisplayedInTheList(string name)
        {
            Assert.That(vuePage.GetAllToDosText, !Has.Member(name));
        }

        [StepDefinition(@"I click on the toggle all button")]
        public void WhenIClickOnTheToggleAllButton()
        {
            vuePage.ClickToggleAllButton();
        }

        [StepDefinition(@"Verify all listed todos are completed")]
        public void ThenVerifyAllListedTodosAreCompleted()
        {
            Assert.IsTrue(vuePage.AreAllToDosCompleted, "Not all todos are completed!");
        }

        [StepDefinition(@"Verify all listed todos are active")]
        public void ThenVerifyAllListedTodosAreActive()
        {
            Assert.IsFalse(vuePage.AreAllToDosCompleted, "Not all todos are active!");
        }

        [Then(@"Verify the footer section is not displayed")]
        public void ThenVerifyTheFooterSectionIsNotDisplayed()
        {
            Assert.IsFalse(vuePage.IsTheFooterDisplayed, "The footer section is displayed");
        }

        [Then(@"Verify To Do field placeholder is displayed")]
        public void ThenVerifyToDoFieldPlaceholderIsDisplayed()
        {
            string expectedPlaceholder = "What needs to be done?";
            Assert.AreEqual(expectedPlaceholder, vuePage.GetToDoFieldText);
        }

    }
}