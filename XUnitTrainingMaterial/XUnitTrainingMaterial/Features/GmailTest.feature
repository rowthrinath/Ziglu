Feature: GmailTest
	In order to test gmail account

@mytag
Scenario: To test invalid validation in gmail login
	Given I have gmail login page loaded
	And I enter an invalid user name and password
	#When I click login button
	#Then I can see a warning message
