using System;
using TechTalk.SpecFlow;

namespace Saitama.Specs.Steps
{
    [Binding]
    public class NextDaySchedulingSteps
    {
        [Given]
        public void a_job_is_configured_to_run_tomorrow()
        {
            ScenarioContext.Current.Pending();
        }

        [Given]
        public void a_job_is_configured_to_run_tomorrow_at_a_given_time()
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void it_should_run_once_sometime_on_the_following_day()
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void it_should_run_once_sometime_on_the_following_DAY(DayOfWeek day)
        {
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void it_should_run_once_at_the_specified_time_on_the_following_day()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
