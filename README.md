# Business Days Counter

This Windows Console App was developed using TDD and SOLID principle.

## Run the App:
1. Download the code from Github repository.
2. Open the 'BusinessDaysCounter.sln' file on Visual Studio 2019 and build the solution.
3. Run the project and have fun with BUSINESS DAYS COUNTER!

Extra: Open Test Explorer on the menu 'Test > Test Explorer'. Run the tests and make sure they are all passing.

## Requirements

### Task 1 – Weekdays between two dates
```
We need a function to calculate business days between two dates
Assume weekdays are Monday to Friday
The returned count should exclude the from date and to date
Example:
-	From Wed 4 August 2021 to Fri 6 August 2021 should return 1
-	From Mon 2 August 2021 to Thu 12 August 2021 should return 7
```
### Task 2 – Business days between two dates considering fixed holidays
```
Extend the solution to exclude a set of fixed public holidays
Assume weekdays are Monday to Friday
The returned count should exclude the from date and to date
The returned count should exclude dates from a (configurable) list of public holidays
Example:
A list of public holidays:
Sun 4 April 2021
Mon 5 April 2021
Sun 25 April 2021
From Thu 1 April 2021 to Wed 7 April 2021 should return 2
```
### Task 3 - Business days between two dates considering dynamic holidays
```
Public holidays are more complex than a simple fixed list of dates. Generally, three types occur:
1.	Always on the same day even if it is a weekend 
2.	An additional day if it falls on a weekend (like New Year’s Day holiday)
3.	Certain occurrence on a certain day in the month
Extend the solution to cater for a public holiday that occurs on a certain day in the month 
(like Queen’s Birthday on the second Monday in June every year)
This should be extensible in future to support the other holiday types
```
