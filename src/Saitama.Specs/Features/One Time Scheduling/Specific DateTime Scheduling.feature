@Owner:adebunky@gmail.com
Feature: Specific Date Time Scheduling
     As a automation enthusiast
     I would like to be able to run tasks once on specific moments
     So that i am able run tasks like user feedback request after a month of registration,
     trial period complete notifications, Anniversary notifications, e-mail dispatch e.t.c
    
Scenario Outline: Schedule a job to run on a specific date and time
    Given the current date and time are <current_date_and_time>
      And a job is configured to run on "<schedule>"
     When scheduled
     Then it should run once after "<time_to_execution>"

    Examples: 
   | current_date_and_time       | schedule                    | time_to_execution | info               |
   | 2019-01-01T00:00:00.0+00:00 | 2020-01-01T00:00:00.0+00:00 | 365.00:00:00      | a year             |
   | 2020-01-01T00:00:00.0+00:00 | 2021-01-01T00:00:00.0+00:00 | 366.00:00:00      | a leap year        |
   | 2019-01-01T00:00:00.0+00:00 | 2019-01-01T00:00:00.0+00:00 | 1.00:00:00        | a day              |
   | 2019-01-01T00:00:00.0+00:00 | 2019-02-01T00:00:00.0+00:00 | 31.00:00:00       | a 31 day month     |
   | 2019-01-01T00:00:00.0+00:00 | 2019-02-01T01:00:00.0+00:00 | 31.01:00:00       | a 31 day month     |
   | 2019-02-01T00:00:00.0+00:00 | 2019-02-28T00:00:00.0+00:00 | 27.00:00:00       | february           |
   | 2020-02-01T00:00:00.0+00:00 | 2020-02-29T00:00:00.0+00:00 | 28.00:00:00       | leap year february |

   
Scenario Outline: Schedule a job to run next week on specific weekday
    Given the current date and time are "<current_date_and_time>"
      And a job is configured to run next week <day_of_week>
     When scheduled
     Then it should run once after "<time_to_execution>"

    Examples: 
   | current_date_and_time       | day_of_week | time_to_execution |
   | 2019-01-01T00:00:00.0+00:00 | Monday      | 6.00:00:00        |
   | 2019-01-01T00:00:00.0+00:00 | Tuesday     | 7.00:00:00        |
   | 2019-01-01T00:00:00.0+00:00 | Wednesday   | 8.00:00:00        |
   | 2019-01-01T00:00:00.0+00:00 | Thursday    | 9.00:00:00        |
   | 2019-01-01T00:00:00.0+00:00 | Friday      | 10.00:00:00       |
   | 2019-01-01T00:00:00.0+00:00 | Saturday    | 11.00:00:00       |
   | 2019-01-01T00:00:00.0+00:00 | Sunday      | 12.00:00:00       |
      