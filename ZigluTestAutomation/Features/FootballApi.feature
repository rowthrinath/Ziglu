Feature: Football API Tests
	In order to test football API operations

	Background: 
	Given I have access  to football api service

@Api
Scenario: Test to check GET method on release endpoint
	When I submit a get on v2/teams/league/2 endpoint
	Then I get a 200 response
	

	@API
Scenario: To find the most goal scored team in home games
		When I get the home goals scored by the teams
		| Team1               | Team2             | Team3             | Team1Endpoint      | Team2Endpoint        | Team3Endpoint      |
		| Paris Saint Germain | Arminia Bielefeld | Manchester United | v2/statistics/4/85 | v2/statistics/36/188 | v2/statistics/2/33 |
		Then I should be able to find the most scored team in home games

@API
Scenario: To find the team in the best current form
		When I get the wins by the teams
		| Team1               | Team2             | Team3             | Team1Endpoint      | Team2Endpoint        | Team3Endpoint      |
		| Paris Saint Germain | Arminia Bielefeld | Manchester United | v2/statistics/4/85 | v2/statistics/36/188 | v2/statistics/2/33 |
		Then I should be able to find the team in form

@Api
Scenario:	To find the results and tropies of football manager Eddie Howe
		When I have the results and tropies of Eddie Howe
		Then I should be able to see the results and tropies of Eddie Howe output