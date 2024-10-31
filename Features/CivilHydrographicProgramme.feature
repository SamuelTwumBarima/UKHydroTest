Feature: CivilHydrographicProgramme

A user validates information on Civil Hydrography Programme

@tag1
Scenario: visit civil hydrography page and check details
	Given I open the UK hydrographic office page
	And I select "Civil Hydrography Programme (CHP)"
	Then I should be on the "The Civil Hydrography Programme - GOV.UK" homepage
	And I validate that the details are displayed
	| Input        | Value                  |
	| From         | UK Hydrographic Office |
	| Published    | 29 August 2014         |
	| Last updated | 12 September 2024      |
