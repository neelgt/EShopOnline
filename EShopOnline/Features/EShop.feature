Feature: EShop

A short summary of the feature

@tag1
Scenario: Add product and place order
	Given Open Home Page
	Then Click on login
	When Enter email 'admin@microsoft.com'
	And Enter password 'Pass@word1'
	Then Successfull login
	When Add item
	Then Go to checkout
	And Place order
