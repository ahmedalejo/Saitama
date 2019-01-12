using System;
using System.Globalization;
using TechTalk.SpecFlow;

namespace Saitama.Specs.Steps
{
    [Binding]
    public class DateTimeTransforms
    {
        [StepArgumentTransformation(@"now")]
        public DateTime GetDateTimeNow()
        {
            return DateTime.UtcNow;
        }

        [StepArgumentTransformation(@"today")]
        public DateTime GetTodaysDate()
        {
            return GetDateTimeNow().Date;
        }

        [StepArgumentTransformation(@"tomorrow")]
        public DateTime GetTomorrowsDate()
        {
            return GetSameTimeTomorrowsDate().Date;
        }

        [StepArgumentTransformation(@"same time tomorrow")]
        public DateTime GetSameTimeTomorrowsDate()
        {
            return GetDateTimeNow().AddDays(1);
        }

        [StepArgumentTransformation("(.*)")]
        public DateTime ConvertDate(string date)
        {
            return DateTime.Parse(date, new CultureInfo("en-US"), DateTimeStyles.AssumeUniversal);
        }
    }
}
