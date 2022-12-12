Feature: AutomationTestingRegistration
	In order to use all the features of Automation  Testing, A customer will have to register on "http://demo.automationtesting.in/Register.html"

@mytag
Scenario: Valid Registration
	Given I navigate to website
	And I type in First Name
	And I type in Last Name
	And I type in Address
	And I type in Email Address
	And I type in Phone
	And I select Gender
	And I select  Hobbies
	And I select Languages
	And I type in Password
	And I type in Confirm Password
	When I click  on Submit
	Then I should be able to Sign Up