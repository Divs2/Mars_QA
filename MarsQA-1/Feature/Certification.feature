Feature: Certification
	

@mytag
Scenario: Add Seller's certificate
	Given  Seller has clicked on  Certification tab
	And Seller has clicked on Add New
	And  Seller has added  Certificate
	And Seller has added certified from
	And Seller has selected year
	When seller clicks on Add button
	Then Seller's Cetification must be saved and visible

	Scenario: Edit Seller's certificate
	Given  Seller has clicked on  Certification tab
	And Seller has clicked on edit
	And  Seller has edit  Certificate
	And Seller has edit certified from
	And Seller has edit year
	When seller clicks on update button
	Then Seller's Cerification must be saved and visible

	Scenario: Delete Seller's Certifications
	Given  Seller has clicked on  Education tab
	When seller clicks on delete button
	Then Seller's  certification must be deleted