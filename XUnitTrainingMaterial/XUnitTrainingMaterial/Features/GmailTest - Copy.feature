Feature: GmailTest2
	In order to test gmail account

@mytag2
Scenario: To test invalid validation in gmail login1
	Given I have gmail login page loaded
	And I enter an invalid user name and password
	#When I click login button
	#Then I can see a warning message
