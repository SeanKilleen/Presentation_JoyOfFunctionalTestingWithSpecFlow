# Prep

* Start Carnac so it'll show F12.

## First Example: Basic Math

* Show Steps
* Parameterize the step for first number
* Local class variable
* Show output of test steps results
* Show next scenario with auto-complete / syntax highlighting
* Refactor to calculator class as example

## Second Example: List products / Buy Product

* Gherkin Syntax for tables
* Parameterized examples
* Can infer tables, objects from tables, dates, Enums

## Third Example: Sharing Context across steps

* Existing vending machine / sharing steps
* Refactor to use a Scenariocontext
* Refactor to use our own context

## SpecFlow + LivingDoc generation

* `dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI`
* CD to specs folder
* `livingdoc feature-folder .`
