using System;
using TechTalk.SpecFlow;

namespace Saitama.Specs.Steps
{
    [Binding]
    public class ExecutionVerificationSteps
    {
        [Then]
        public void Then_it_should_run_once_on_SCHEDULE(DateTime schedule)
        {

        }

        [Then]
        public void it_should_run_once_sometime_on_SCHEDULE(DateTime schedule)
        {

        }

        [Then]
        public void it_should_run_once_sometime_on_the_following_day()
        {

        }

        [Then]
        public void it_should_run_once_sometime_on_the_following_DAY(DayOfWeek day)
        {

        }

        [Then]
        public void it_should_run_once_at_the_specified_time_on_the_following_day()
        {

        }
    }
}
