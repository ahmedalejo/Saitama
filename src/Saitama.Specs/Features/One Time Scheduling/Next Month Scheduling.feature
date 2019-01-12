@Owner:adebunky@gmail.com
Feature: Next Month Scheduling
     As a automation enthusiast
     I would like to be able to run tasks only once
     So that i can assure the consistency of certain initialization task

#Scenario Outline: Schedule a job to run next month on specific day
#    Given the current time is '<current_date_and_time>'
#      And a job is configured to run on day <number> next month 
#     When scheduled
#     Then the time to execution should be "<time_to_execution>"
#
#    Examples: 
#   | current_date_and_time       | number | time_to_execution |
#   | 2019-01-01T00:00:00.0+00:00 | 1      | 1.00:00:00        |
#   | 2019-01-01T00:00:00.0+00:00 | 2      | 2.00:00:00        |
#   | 2019-01-01T00:00:00.0+00:00 | 3      | 3.00:00:00        |
#   | 2019-01-01T00:00:00.0+00:00 | 4      | 4.00:00:00        |
#   | 2019-01-01T00:00:00.0+00:00 | 5      | 5.00:00:00        |
#
#Scenario: Schedule a job to run next month
#    Given a job is configured to run next month
#     When scheduled
#     Then it should run once on the immediate 1st day of the following month
#     
#Scenario Outline: Schedule a job to run next month [outline]
#    Given it is any day of "<month>", <year>
#      And a job is configured to run next month
#     When scheduled
#     Then it should run once on the immediate 1st day of the following month
#     And the approximate time of execution should be "<date_and_time_of_execution>"
#
#    Examples: 
#   | year | month     | date_and_time_of_execution  |
#   | 2019 | January   | 2019-02-01T00:00:00.0+00:00 |
#   | 2019 | February  | 2019-03-01T00:00:00.0+00:00 |
#   | 2019 | March     | 2019-04-01T00:00:00.0+00:00 |
#   | 2019 | April     | 2019-05-01T00:00:00.0+00:00 |
#   | 2019 | May       | 2019-06-01T00:00:00.0+00:00 |
#   | 2019 | June      | 2019-07-01T00:00:00.0+00:00 |
#   | 2019 | July      | 2019-08-01T00:00:00.0+00:00 |
#   | 2019 | August    | 2019-09-01T00:00:00.0+00:00 |
#   | 2019 | September | 2019-10-01T00:00:00.0+00:00 |
#   | 2019 | October   | 2019-11-01T00:00:00.0+00:00 |
#   | 2019 | November  | 2019-12-01T00:00:00.0+00:00 |
#   | 2019 | December  | 2020-01-01T00:00:00.0+00:00 |
#
#Scenario Outline: Schedule a job to run next month on a specific day
#    Given the current time is "<current_date_and_time>"
#      And a job is configured to run on day <day> next month 
#     When scheduled
#     Then the time to execution should be "<time_to_execution>"
#
#    Examples: 
#   | current_date_and_time       | day | time_to_execution |
#   | 2019-01-01T00:00:00.0+00:00 | 1   | 1.00:00:00        |
#   | 2019-01-01T01:00:00.0+00:00 | 2   | 2.01:00:00        |
#   | 2019-01-01T02:00:00.0+00:00 | 3   | 3.02:00:00        |
#   | 2019-01-01T03:00:00.0+00:00 | 4   | 4.03:00:00        |
#   | 2019-01-01T04:00:00.0+00:00 | 5   | 5.04:00:00        |
#      