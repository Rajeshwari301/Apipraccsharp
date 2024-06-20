Feature: Examples Data driven testing

Search in the youtube

@Testers
Scenario Outline: Examples Data driven testing
	Given Open the browser
	When Enter the URL
	Then Find for <searchkey>
	Examples: 
	| searchkey |
	| aaa       |
	| bbb       |