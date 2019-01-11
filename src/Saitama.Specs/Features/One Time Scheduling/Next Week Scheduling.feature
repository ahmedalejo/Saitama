@Owner:adebunky@gmail.com
Feature: Next Week Scheduling
     As a automation enthusiast
     I would like to be able to run tasks once on specific moments
     So that i am able run tasks like user feedback request after a month of registration,
     trial period complete notifications, Anniversary notifications, e-mail dispatch e.t.c

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
      