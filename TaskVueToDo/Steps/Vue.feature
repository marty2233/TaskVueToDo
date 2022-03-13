Feature: ToDo Workflow
	
@TC001
Scenario Outline: Add new ToDo
    Given I am on the homepage
    When I add a ToDo
        |ToDoName|
        |<item1>|
    Then Verify To Do count in the list is "<expectedCount>"
        And the active items count is "<expectedCount>"
        And Verify the todo "<item1>" is displayed in the list
        And the "All" filter is displayed as selected

    Examples:
    |item1     |expectedCount|
    |First todo|1            |

@TC002
Scenario Outline: Editing a ToDo
    Given I am on the homepage
    When I add a ToDo
        |ToDoName|
        |<item1> |
        |<item2> |
        And Verify To Do count in the list is "2"
        And the active items count is "2"
        And I edit a ToDo with name "<item1>" to "<newName>"
    Then the active items count is "2"
        And Verify the todo "<newName>" is displayed in the list
        And Verify the todo "<item1>" is not displayed in the list

    Examples:
    |item1     |item2      |newName      |
    |First todo|Second todo|New ToDo Name|

@TC003
Scenario Outline: Complete a ToDo
    Given I am on the homepage
    When I add a ToDo
        |ToDoName |
        |<item1>  |
        And I mark "<item1>" as completed
        And I click on the "Completed" filter button
    Then the active items count is "0"
        And Verify To Do count in the list is "1"
        And the "completed" filter is displayed as selected
        And Verify the todo "<item1>" is displayed in the list

    Examples:
    |item1     |
    |First todo|

@TC004
Scenario Outline: Delete a ToDo
    Given I am on the homepage
    When I add a ToDo
        |ToDoName|
        |<item1>|
        |<item2>|
        And Verify To Do count in the list is "2"
        And the active items count is "2"
        And I delete the ToDo with name "<item1>"
    Then the active items count is "1"
        And Verify the todo "<item1>" is not displayed in the list

    Examples:
    |item1     |item2      |
    |First todo|Second todo|

@TC005
Scenario Outline:  Uncomplete a ToDo
    Given I am on the homepage
        And I add a ToDo
        |ToDoName|
        |<item1> |
        And the active items count is "1"
        And I mark "<item1>" as completed
        And the active items count is "0"
    When I uncomplete "<item1>"
    Then Verify To Do count in the list is "1"
        And the active items count is "1"
        And Verify all listed todos are active

    Examples:
    |item1     |
    |First todo|

@TC006 @TC008
Scenario Outline: Mark all Active ToDos as Completed
    Given I am on the homepage
        And I add a ToDo
        |ToDoName |
        |<item1>  |
        |<item2>  |
        |<item3>  |
        |<item4>  |
        And the active items count is "4"
    When I click on the toggle all button
    Then the active items count is "0"
        And Verify To Do count in the list is "4"
        And Verify all listed todos are completed

    Examples:
    |item1     |item2      |item3     |item4      |
    |First todo|Second todo|Third todo|Fourth todo|

@TC007
Scenario Outline:  Uncomplete all Completed ToDos
    Given I am on the homepage
        And I add a ToDo
        |ToDoName |
        |<item1>  |
        |<item2>  |
        |<item3>  |
        |<item4>  |
        And the active items count is "4"
        And I click on the toggle all button
        And the active items count is "0"
    When I click on the toggle all button
    Then Verify To Do count in the list is "4"
        And Verify all listed todos are active

    Examples:
    |item1     |item2      |item3     |item4      |
    |First todo|Second todo|Third todo|Fourth todo|

@TC009
Scenario Outline:  Filter by Active
    Given I am on the homepage
        And I add a ToDo
        |ToDoName |
        |<item1>  |
        |<item2>  |
        And I mark "<item1>" as completed
        And the active items count is "1"
        And Verify To Do count in the list is "2"
    When I click on the "Active" filter button
    Then Verify To Do count in the list is "1"
        And Verify all listed todos are active

    Examples:
    |item1     |item2      |
    |First todo|Second todo|

@TC010
Scenario Outline: All saved todos are loaded after page refresh
    Given I am on the homepage
        And I add a ToDo
        |ToDoName|
        |<item1> | 
        |<item2> |
    When I refresh the page
    Then Verify To Do count in the list is "<expectedCount>"
        And the active items count is "<expectedCount>"
        And Verify the todo "<item1>" is displayed in the list
        And Verify the todo "<item2>" is displayed in the list
        And the "All" filter is displayed as selected

    Examples:
    |item1     |item2      |expectedCount|
    |First todo|Second todo|2            | 

@TC011
Scenario Outline: Add new todo when Completed filter is selected
    Given I am on the homepage
        And I add a ToDo
        |ToDoName |
        |<item1>  |
        And I mark "<item1>" as completed
        And the active items count is "0"
        And Verify To Do count in the list is "1"
    When I click on the "Completed" filter button
        And I add a ToDo
        |ToDoName |
        |<item2>  |
    Then Verify To Do count in the list is "1"
        And the active items count is "1"

    Examples:
    |item1     |item2      |
    |First todo|Second todo|

@TC012
Scenario Outline: Add new todo when Active filter is selected
    Given I am on the homepage
        And I add a ToDo
        |ToDoName |
        |<item1>  |
        And the active items count is "1"
        And Verify To Do count in the list is "1"
    When I click on the "Active" filter button
        And I add a ToDo
        |ToDoName |
        |<item2>  |
    Then Verify To Do count in the list is "2"
        And the active items count is "2"

    Examples:
    |item1     |item2      |
    |First todo|Second todo|

@TC013
Scenario Outline: Clear completed button clear all completed todos
    Given I am on the homepage
        And the Clear completed button is not displayed
        And I add a ToDo
        |ToDoName |
        |<item1>  |
        |<item2>  |
        And the active items count is "2"
        And I mark "<item1>" as completed
        And Verify To Do count in the list is "2"
    When I click on the Clear Completed button
        And I refresh the page
    Then Verify To Do count in the list is "1"
        And the active items count is "1"
        And I click on the "Completed" filter button
        And Verify To Do count in the list is "0"

    Examples:
    |item1     |item2      |
    |First todo|Second todo|

@TC014 
Scenario Outline: Mark all Active ToDos as Completed when there is already one completed todo
    Given I am on the homepage
        And I add a ToDo
        |ToDoName |
        |<item1>  |
        |<item2>  |
        |<item3>  |
        And I mark "<item2>" as completed
        And the active items count is "2"
    When I click on the toggle all button
    Then the active items count is "0"
        And Verify To Do count in the list is "3"
        And Verify all listed todos are completed

    Examples:
    |item1     |item2      |item3     |
    |First todo|Second todo|Third todo|

@TC015 @TC016
Scenario Outline: Editing a ToDo with empty name deletes the todo
    Given I am on the homepage
        And I add a ToDo
        |ToDoName|
        |<item1> |
        And Verify To Do count in the list is "1"
        And the active items count is "1"
        And I edit a ToDo with name "<item1>" to " "
    Then Verify the footer section is not displayed
        And Verify To Do field placeholder is displayed

    Examples:
    |item1     |
    |First todo|

@TC018 @TC019 @TC020 @TC021
Scenario Outline: Add todos with with special char, alert(), long text and in Chinese
    Given I am on the homepage
    When I add a ToDo
        |ToDoName |
        |<item1>  |
        |<item2>  |
        |<item3>  |
        |<item4>  |
        And the active items count is "4"
    Then Verify the following todos are displayed in the list
        |ToDoName |
        |<item1>  |
        |<item2>  |
        |<item3>  |
        |<item4>  |

    Examples:
    |item1 |item2                   |item3       |item4                                                                     |
    |@#$%&*|alert("This is a test");|汉语考试服务  |Lorem Ipsum is simply dummy text of the printing and typesetting industry.|