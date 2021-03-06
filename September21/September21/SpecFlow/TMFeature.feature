Feature: TMFeature
	Working as a turnup portal admin
	I will like to create, edith, delete the employee, time and material records
	So I can successfully manage the employees time and material records

@tmtest @regression
Scenario: Create time and material with valid details
	Given I login to turn up portal successfully
	And I navigate to the time and material page
	When I create time and material record
	Then The record should be created successfully

#
#	Scenario: Edit time and material details
#	Given I login to turn up portal successfully
#	And I navigate to the time and material page 
#	When I edit the record and save
#	Then The record should be updated successfully

	Scenario: Delete time and material details
	Given I login to turn up portal successfully
	And I navigate to the time and material page 
	When I delete a record
	Then The record should be successfully deleted

	@tmtest @regression
Scenario Outline: Edit time and material details
	Given I login to turn up portal successfully
	And I navigate to the time and material page
	When I update '<Description>' on existing time and material record
	Then The record should have '<Description>' updated successfully

	Examples: 
	| Description |
	| Alpha    |
	| Omega    |
	| Romeo    |

@Emptest @regression
Scenario: Create employees with valid details
	Given I login to turn up portal successfully
	And I navigate to employee details page
	When I create employee record
	Then The record should be created successfully

	Scenario: Edit Employee details
	Given I navigate to the employee details page
	And I select a record by clicking on the edit button for the record 
	When I edit the details and save
	Then The details should be updated successfully

	Scenario: Delete Employee details
	Given I navigate to the employee details page
	And I select a record by clicking on the edit button for the employee
	When I edit the details and save
	Then The details should be successfully deleted