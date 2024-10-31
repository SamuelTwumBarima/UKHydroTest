Feature: Visist all links on UK Hydrographic page

A short summary of the feature

@tag1
Scenario: Visit admiralty page and check title
	Given I go to url "https://www.gov.uk/government/organisations/uk-hydrographic-office"
	And I select "ADMIRALTY"
	Then I should be on the "ADMIRALTY" homepage


	Scenario Outline: Visit admiralty page and check title1
	Given I go to url "https://www.gov.uk/government/organisations/uk-hydrographic-office"
	And I select "<linkName>" link
	Then I should be on the "<pageTitle>" homepage
	
	Examples:
	| linkName                                                | pageTitle                                                                                         |
	| ADMIRALTY                                               | ADMIRALTY                                                                                         |
	| Our role in government                                  | Supporting government with marine geospatial data                                                 |
	| Cartographic training                                   | About our services - UK Hydrographic Office - GOV.UK                                              |
	| Copyright licensing                                     | Introduction to Copyright Licensing                                                               |
	| Civil Hydrography Programme (CHP)                       | The Civil Hydrography Programme - GOV.UK                                                          |
	| HM Nautical Almanac Office (HMNAO)                      | HM Nautical Almanac Office - GOV.UK                                                               |
	| UKHO Archive                                            | The UK Hydrographic Office (UKHO) Archive - GOV.UK                                                |
	| UK Maritime Limits and Law of the Sea                   | UK, UK Overseas Territories and UK Crown Dependencies Maritime Limits and Law of the Sea - GOV.UK |

