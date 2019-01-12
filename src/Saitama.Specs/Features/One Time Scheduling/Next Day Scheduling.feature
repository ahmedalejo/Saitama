@Owner:adebunky@gmail.com

Feature: Next Day Scheduling
     As a automation enthusiast
     I would like to be able to run tasks only once
     So that i can assure the consistency of certain initialization task

Scenario: Schedule a job to run tomorrow
    Given a job is configured to run tomorrow
     When scheduled
     Then it should run once sometime on the following day
     
Scenario Outline: Schedule a job to run tomorrow [outline]
    Given today is <current_date>
      And a job is configured to run tomorrow
     When scheduled
     Then it should run once sometime on <date_to_run>

    Examples: 
   | current_date               | date_to_run               |
   | Monday    December 31 2018 | Tuesday   January 01 2018 |
   | Tuesday   January  01 2019 | Wednesday January 02 2019 |
   | Wednesday January  02 2019 | Thursday  January 03 2019 |
   | Thursday  January  03 2019 | Friday    January 04 2019 |
   | Friday    January  04 2019 | Saturday  January 05 2019 |
   | Saturday  January  05 2019 | Sunday    January 06 2019 |
   | Sunday    January  06 2019 | Monday    January 07 2019 |

Scenario: Schedule a job to run tomorrow at a certain time
    Given a job is configured to run tomorrow at a given time
     When scheduled
     Then it should run once at the specified time on the following day
     
Scenario Outline: Schedule a job to run tomorrow at a certain time [outline]
    Given today is <current_date_and_time>
      And a job is configured to run tomorrow at a given time
     When scheduled
     Then it should run once on today
     
     Examples: 
     | current_date_and_time            | date_and_time_to_run            |
     | Monday    December 31 2018 00:00 | Tuesday   January 01 2019 00:00 |
     #| Tuesday   January  01 2019 02:15 | Wednesday January 02 2019 02:15 |
     #| Wednesday January  02 2019 02:30 | Thursday  January 03 2019 02:30 |
     #| Thursday  January  03 2019 04:45 | Friday    January 04 2019 04:45 |
     #| Friday    January  04 2019 06:00 | Saturday  January 05 2019 06:00 |
     #| Saturday  January  05 2019 10:15 | Sunday    January 06 2019 10:15 |
     #| Sunday    January  06 2019 16:30 | Monday    January 07 2019 16:30 |
      