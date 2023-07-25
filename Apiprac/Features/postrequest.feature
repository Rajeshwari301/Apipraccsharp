Feature: post request for webapi

A short summary of the feature

@tag1
Scenario: post api validation
	Given I send a request with posturl "https://reqres.in/api/users"
	Then The request succeeds with status 200
