Feature: ValidateLogin

A short summary of the feature

@tag1
Scenario: InValid Login
	Given Navigate to Home Page
	Then Click login
	When Enter mail 'admin123@microsoft.com'
	And Enter pass 'Pass@word1'
	Then Invalid login
	
@tag1
Scenario: Valid Login	
	Given Open Home Page
	Then Click on login
	When Enter email 'admin@microsoft.com'
	And Enter password 'Pass@word1'
	Then Successfull login
