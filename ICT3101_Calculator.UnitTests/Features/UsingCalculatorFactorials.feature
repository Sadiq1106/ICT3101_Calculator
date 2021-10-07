Feature: UsingCalculatorFactorials
	Simple calculator for adding two numbers

@factorial
Scenario: Factorial a number
	Given I have a calculator
	When I have entered "5" into the calculator and press factorial
	Then the factorial result should be "120"

@factorialzero
Scenario: Factorial a zero
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"
