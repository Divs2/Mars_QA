Feature: ShareSkills
	
@mytag
Scenario:1 Add Seller's Share Skill
	Given  Seller has clicked on  Share Skill 
	And Seller has added title
	But Seller can only write 100 characters on title
	And  Seller has added  description
	But Seller can only write 600 characters on description
	And Seller has chosen category
	And Seller has chosen subcategory
	And Seller has added tag
	And Seller has chosen service type
	And Seller has chosen location type
	And Seller has selected start date and end date
	And Seller has specified start and end times for each avaiable day
	And Seller has chosen skill trend
	And Seller has added skill exchange
	And Seller has uploaded work samples
	And Seller has chosen enable or disable services
	When seller clicks on Save button
	Then Seller's share skill must be saved and visible


	Scenario:2 enable or disable Seller's exciting Share Skill
	Given  Seller must be on Manage Listings tab
	When  Seller  clicks on toggle button below active
	Then Seller can must be able to change status of their service
	
	
	
	Scenario:3 Edit Seller's Share Skill
	Given  Seller has clicked on  Manage Listings 
	And  Seller has click on edit Share Skill
	And Seller has edited title
	But Seller can only write 100 characters on title
	And  Seller has edited  description
	But Seller can only write 600 characters on description
	And Seller has chosen new category
	And Seller has chosen new subcategory
	And Seller has edited tag
	And Seller has chosen new service type
	And Seller has chosen  new location type
	And Seller has selected  new start date and end date
	And Seller has specified new start and end times for each avaiable day
	And Seller has chosen  new skill trend
	And Seller has edited skill exchange
	And Seller has uploaded new work samples
	And Seller has edited enable or disable services
	When seller clicks on Save button
	Then Seller's udated share skill must be saved and visible


	Scenario:4 Delete Seller's Share Skill
	Given  Seller has clicked on  Manage Listings
	And  seller clicked on delete button
	When  Seller  clicks on yes
	Then Seller's  Share Skill must be deleted


	
	