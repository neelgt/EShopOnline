Feature: ValidateLogin

A short summary of the feature

@tag1
Scenario: InValid Login
	Given Navigate to Home Page
	Then Click login
	When Enter Credentials
	| Key         | Value                  |
	| username    | admin123@microsoft.com |
	| password    | Pass@word1             |
	Then Invalid login
	
@tag1
Scenario: Valid Login	
	Given Open Home Page
	Then Click on login
	When Enter Credentials
	| Key         | Value                  |
	| username    | admin@microsoft.com |
	| password    | Pass@word1             |
	Then Successfull login
