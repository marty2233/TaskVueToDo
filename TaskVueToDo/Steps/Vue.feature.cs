// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TaskVueToDo.Steps
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ToDo Workflow")]
    public partial class ToDoWorkflowFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Vue.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ToDo Workflow", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new ToDo")]
        [NUnit.Framework.CategoryAttribute("TC001")]
        [NUnit.Framework.TestCaseAttribute("First todo", "1", null)]
        public virtual void AddNewToDo(string item1, string expectedCount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC001"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new ToDo", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table1.AddRow(new string[] {
                        string.Format("{0}", item1)});
#line 6
    testRunner.When("I add a ToDo", ((string)(null)), table1, "When ");
#line 9
    testRunner.Then(string.Format("Verify To Do count in the list is \"{0}\"", expectedCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
        testRunner.And(string.Format("the active items count is \"{0}\"", expectedCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
        testRunner.And(string.Format("Verify the todo \"{0}\" is displayed in the list", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
        testRunner.And("the \"All\" filter is displayed as selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Editing a ToDo")]
        [NUnit.Framework.CategoryAttribute("TC002")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", "New ToDo Name", null)]
        public virtual void EditingAToDo(string item1, string item2, string newName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC002"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing a ToDo", null, @__tags);
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table2.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table2.AddRow(new string[] {
                        string.Format("{0}", item2)});
#line 21
    testRunner.When("I add a ToDo", ((string)(null)), table2, "When ");
#line 25
        testRunner.And("Verify To Do count in the list is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
        testRunner.And("the active items count is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
        testRunner.And(string.Format("I edit a ToDo with name \"{0}\" to \"{1}\"", item1, newName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.Then("the active items count is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
        testRunner.And(string.Format("Verify the todo \"{0}\" is displayed in the list", newName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
        testRunner.And(string.Format("Verify the todo \"{0}\" is not displayed in the list", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Complete a ToDo")]
        [NUnit.Framework.CategoryAttribute("TC003")]
        [NUnit.Framework.TestCaseAttribute("First todo", null)]
        public virtual void CompleteAToDo(string item1, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC003"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Complete a ToDo", null, @__tags);
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 38
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table3.AddRow(new string[] {
                        string.Format("{0}", item1)});
#line 39
    testRunner.When("I add a ToDo", ((string)(null)), table3, "When ");
#line 42
        testRunner.And(string.Format("I mark \"{0}\" as completed", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
        testRunner.And("I click on the \"Completed\" filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.Then("the active items count is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
        testRunner.And("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
        testRunner.And("the \"completed\" filter is displayed as selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
        testRunner.And(string.Format("Verify the todo \"{0}\" is displayed in the list", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete a ToDo")]
        [NUnit.Framework.CategoryAttribute("TC004")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", null)]
        public virtual void DeleteAToDo(string item1, string item2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC004"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete a ToDo", null, @__tags);
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 55
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table4.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table4.AddRow(new string[] {
                        string.Format("{0}", item2)});
#line 56
    testRunner.When("I add a ToDo", ((string)(null)), table4, "When ");
#line 60
        testRunner.And("Verify To Do count in the list is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
        testRunner.And("the active items count is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
        testRunner.And(string.Format("I delete the ToDo with name \"{0}\"", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
    testRunner.Then("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
        testRunner.And(string.Format("Verify the todo \"{0}\" is not displayed in the list", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Uncomplete a ToDo")]
        [NUnit.Framework.CategoryAttribute("TC005")]
        [NUnit.Framework.TestCaseAttribute("First todo", null)]
        public virtual void UncompleteAToDo(string item1, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC005"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Uncomplete a ToDo", null, @__tags);
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 72
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table5.AddRow(new string[] {
                        string.Format("{0}", item1)});
#line 73
        testRunner.And("I add a ToDo", ((string)(null)), table5, "And ");
#line 76
        testRunner.And("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
        testRunner.And(string.Format("I mark \"{0}\" as completed", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
        testRunner.And("the active items count is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
    testRunner.When(string.Format("I uncomplete \"{0}\"", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
    testRunner.Then("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
        testRunner.And("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
        testRunner.And("Verify all listed todos are active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mark all Active ToDos as Completed")]
        [NUnit.Framework.CategoryAttribute("TC006")]
        [NUnit.Framework.CategoryAttribute("TC008")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", "Third todo", "Fourth todo", null)]
        public virtual void MarkAllActiveToDosAsCompleted(string item1, string item2, string item3, string item4, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC006",
                    "TC008"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mark all Active ToDos as Completed", null, @__tags);
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 90
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table6.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table6.AddRow(new string[] {
                        string.Format("{0}", item2)});
            table6.AddRow(new string[] {
                        string.Format("{0}", item3)});
            table6.AddRow(new string[] {
                        string.Format("{0}", item4)});
#line 91
        testRunner.And("I add a ToDo", ((string)(null)), table6, "And ");
#line 97
        testRunner.And("the active items count is \"4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
    testRunner.When("I click on the toggle all button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
    testRunner.Then("the active items count is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
        testRunner.And("Verify To Do count in the list is \"4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
        testRunner.And("Verify all listed todos are completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Uncomplete all Completed ToDos")]
        [NUnit.Framework.CategoryAttribute("TC007")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", "Third todo", "Fourth todo", null)]
        public virtual void UncompleteAllCompletedToDos(string item1, string item2, string item3, string item4, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC007"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Uncomplete all Completed ToDos", null, @__tags);
#line 108
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 109
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table7.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table7.AddRow(new string[] {
                        string.Format("{0}", item2)});
            table7.AddRow(new string[] {
                        string.Format("{0}", item3)});
            table7.AddRow(new string[] {
                        string.Format("{0}", item4)});
#line 110
        testRunner.And("I add a ToDo", ((string)(null)), table7, "And ");
#line 116
        testRunner.And("the active items count is \"4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
        testRunner.And("I click on the toggle all button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
        testRunner.And("the active items count is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
    testRunner.When("I click on the toggle all button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
    testRunner.Then("Verify To Do count in the list is \"4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
        testRunner.And("Verify all listed todos are active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Filter by Active")]
        [NUnit.Framework.CategoryAttribute("TC009")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", null)]
        public virtual void FilterByActive(string item1, string item2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC009"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter by Active", null, @__tags);
#line 128
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 129
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table8.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table8.AddRow(new string[] {
                        string.Format("{0}", item2)});
#line 130
        testRunner.And("I add a ToDo", ((string)(null)), table8, "And ");
#line 134
        testRunner.And(string.Format("I mark \"{0}\" as completed", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
        testRunner.And("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
        testRunner.And("Verify To Do count in the list is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
    testRunner.When("I click on the \"Active\" filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
    testRunner.Then("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
        testRunner.And("Verify all listed todos are active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("All saved todos are loaded after page refresh")]
        [NUnit.Framework.CategoryAttribute("TC010")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", "2", null)]
        public virtual void AllSavedTodosAreLoadedAfterPageRefresh(string item1, string item2, string expectedCount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC010"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All saved todos are loaded after page refresh", null, @__tags);
#line 146
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 147
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table9.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table9.AddRow(new string[] {
                        string.Format("{0}", item2)});
#line 148
        testRunner.And("I add a ToDo", ((string)(null)), table9, "And ");
#line 152
    testRunner.When("I refresh the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
    testRunner.Then(string.Format("Verify To Do count in the list is \"{0}\"", expectedCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
        testRunner.And(string.Format("the active items count is \"{0}\"", expectedCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
        testRunner.And(string.Format("Verify the todo \"{0}\" is displayed in the list", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
        testRunner.And(string.Format("Verify the todo \"{0}\" is displayed in the list", item2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
        testRunner.And("the \"All\" filter is displayed as selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new todo when Completed filter is selected")]
        [NUnit.Framework.CategoryAttribute("TC011")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", null)]
        public virtual void AddNewTodoWhenCompletedFilterIsSelected(string item1, string item2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC011"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new todo when Completed filter is selected", null, @__tags);
#line 164
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 165
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table10.AddRow(new string[] {
                        string.Format("{0}", item1)});
#line 166
        testRunner.And("I add a ToDo", ((string)(null)), table10, "And ");
#line 169
        testRunner.And(string.Format("I mark \"{0}\" as completed", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
        testRunner.And("the active items count is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
        testRunner.And("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
    testRunner.When("I click on the \"Completed\" filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table11.AddRow(new string[] {
                        string.Format("{0}", item2)});
#line 173
        testRunner.And("I add a ToDo", ((string)(null)), table11, "And ");
#line 176
    testRunner.Then("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 177
        testRunner.And("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new todo when Active filter is selected")]
        [NUnit.Framework.CategoryAttribute("TC012")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", null)]
        public virtual void AddNewTodoWhenActiveFilterIsSelected(string item1, string item2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC012"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new todo when Active filter is selected", null, @__tags);
#line 184
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 185
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table12.AddRow(new string[] {
                        string.Format("{0}", item1)});
#line 186
        testRunner.And("I add a ToDo", ((string)(null)), table12, "And ");
#line 189
        testRunner.And("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
        testRunner.And("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
    testRunner.When("I click on the \"Active\" filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table13.AddRow(new string[] {
                        string.Format("{0}", item2)});
#line 192
        testRunner.And("I add a ToDo", ((string)(null)), table13, "And ");
#line 195
    testRunner.Then("Verify To Do count in the list is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
        testRunner.And("the active items count is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clear completed button clear all completed todos")]
        [NUnit.Framework.CategoryAttribute("TC013")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", null)]
        public virtual void ClearCompletedButtonClearAllCompletedTodos(string item1, string item2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC013"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clear completed button clear all completed todos", null, @__tags);
#line 203
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 204
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 205
        testRunner.And("the Clear completed button is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table14.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table14.AddRow(new string[] {
                        string.Format("{0}", item2)});
#line 206
        testRunner.And("I add a ToDo", ((string)(null)), table14, "And ");
#line 210
        testRunner.And("the active items count is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 211
        testRunner.And(string.Format("I mark \"{0}\" as completed", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 212
        testRunner.And("Verify To Do count in the list is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 213
    testRunner.When("I click on the Clear Completed button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 214
        testRunner.And("I refresh the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 215
    testRunner.Then("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 216
        testRunner.And("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 217
        testRunner.And("I click on the \"Completed\" filter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 218
        testRunner.And("Verify To Do count in the list is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mark all Active ToDos as Completed when there is already one completed todo")]
        [NUnit.Framework.CategoryAttribute("TC014")]
        [NUnit.Framework.TestCaseAttribute("First todo", "Second todo", "Third todo", null)]
        public virtual void MarkAllActiveToDosAsCompletedWhenThereIsAlreadyOneCompletedTodo(string item1, string item2, string item3, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC014"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mark all Active ToDos as Completed when there is already one completed todo", null, @__tags);
#line 225
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 226
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table15.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table15.AddRow(new string[] {
                        string.Format("{0}", item2)});
            table15.AddRow(new string[] {
                        string.Format("{0}", item3)});
#line 227
        testRunner.And("I add a ToDo", ((string)(null)), table15, "And ");
#line 232
        testRunner.And(string.Format("I mark \"{0}\" as completed", item2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 233
        testRunner.And("the active items count is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 234
    testRunner.When("I click on the toggle all button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 235
    testRunner.Then("the active items count is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 236
        testRunner.And("Verify To Do count in the list is \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 237
        testRunner.And("Verify all listed todos are completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Editing a ToDo with empty name deletes the todo")]
        [NUnit.Framework.CategoryAttribute("TC015")]
        [NUnit.Framework.CategoryAttribute("TC016")]
        [NUnit.Framework.TestCaseAttribute("First todo", null)]
        public virtual void EditingAToDoWithEmptyNameDeletesTheTodo(string item1, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC015",
                    "TC016"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing a ToDo with empty name deletes the todo", null, @__tags);
#line 244
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 245
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table16.AddRow(new string[] {
                        string.Format("{0}", item1)});
#line 246
        testRunner.And("I add a ToDo", ((string)(null)), table16, "And ");
#line 249
        testRunner.And("Verify To Do count in the list is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 250
        testRunner.And("the active items count is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 251
        testRunner.And(string.Format("I edit a ToDo with name \"{0}\" to \" \"", item1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 252
    testRunner.Then("Verify the footer section is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 253
        testRunner.And("Verify To Do field placeholder is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add todos with with special char, alert(), long text and in Chinese")]
        [NUnit.Framework.CategoryAttribute("TC018")]
        [NUnit.Framework.CategoryAttribute("TC019")]
        [NUnit.Framework.CategoryAttribute("TC020")]
        [NUnit.Framework.CategoryAttribute("TC021")]
        [NUnit.Framework.TestCaseAttribute("@#$%&*", "alert(\"This is a test\");", "汉语考试服务", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", null)]
        public virtual void AddTodosWithWithSpecialCharAlertLongTextAndInChinese(string item1, string item2, string item3, string item4, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC018",
                    "TC019",
                    "TC020",
                    "TC021"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add todos with with special char, alert(), long text and in Chinese", null, @__tags);
#line 260
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 261
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table17.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table17.AddRow(new string[] {
                        string.Format("{0}", item2)});
            table17.AddRow(new string[] {
                        string.Format("{0}", item3)});
            table17.AddRow(new string[] {
                        string.Format("{0}", item4)});
#line 262
    testRunner.When("I add a ToDo", ((string)(null)), table17, "When ");
#line 268
        testRunner.And("the active items count is \"4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToDoName"});
            table18.AddRow(new string[] {
                        string.Format("{0}", item1)});
            table18.AddRow(new string[] {
                        string.Format("{0}", item2)});
            table18.AddRow(new string[] {
                        string.Format("{0}", item3)});
            table18.AddRow(new string[] {
                        string.Format("{0}", item4)});
#line 269
    testRunner.Then("Verify the following todos are displayed in the list", ((string)(null)), table18, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
