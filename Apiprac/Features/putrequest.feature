Feature: put request for api

A short summary of the feature

@tag1
Scenario: Update api validation
	Given I send a put request with url "https://reqres.in/api/users/2"
	Then the put request succeeds with status 200
