Feature: Scoring
	In order to keep track of my score
	As a bowler
	I want to use an automated scoring system with some other feedback

Scenario: Bowling a strike
	Given I am on the first frame
	When I bowl a strike
	Then I should see an "X" and a message that says "Good Job"
	And I should hear Green Day
Scenario: Bowling a gutter ball as first throw
	Given I am on the first frame
	When I bowl a gutter ball
	Then I should see an "0" and a message that says "bummer"

Scenario: Bowling two gutter balls in a frame
	Given I have bowled a gutter ball already
	When I bowl another gutter ball
	Then I should see an "0" and a message that says "you stink"

