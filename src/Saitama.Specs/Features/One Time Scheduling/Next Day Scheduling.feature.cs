﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Saitama.Specs.Features.OneTimeScheduling
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "Owner:adebunky@gmail.com")]
    public partial class NextDaySchedulingFeature : Xunit.IClassFixture<NextDaySchedulingFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Next Day Scheduling.feature"
#line hidden
        
        public NextDaySchedulingFeature(NextDaySchedulingFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Next Day Scheduling", "     As a automation enthusiast\r\n     I would like to be able to run tasks only o" +
                    "nce\r\n     So that i can assure the consistency of certain initialization task", ProgrammingLanguage.CSharp, new string[] {
                        "Owner:adebunky@gmail.com"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Schedule a job to run tomorrow")]
        [Xunit.TraitAttribute("FeatureTitle", "Next Day Scheduling")]
        [Xunit.TraitAttribute("Description", "Schedule a job to run tomorrow")]
        public virtual void ScheduleAJobToRunTomorrow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Schedule a job to run tomorrow", null, ((string[])(null)));
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
    testRunner.Given("a job is configured to run tomorrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
     testRunner.When("scheduled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
     testRunner.Then("it should run once sometime on the following day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Schedule a job to run tomorrow [outline]")]
        [Xunit.TraitAttribute("FeatureTitle", "Next Day Scheduling")]
        [Xunit.TraitAttribute("Description", "Schedule a job to run tomorrow [outline]")]
        [Xunit.InlineDataAttribute("Monday    December 31 2018", "Tuesday   January 01 2018", new string[0])]
        [Xunit.InlineDataAttribute("Tuesday   January  01 2019", "Wednesday January 02 2019", new string[0])]
        [Xunit.InlineDataAttribute("Wednesday January  02 2019", "Thursday  January 03 2019", new string[0])]
        [Xunit.InlineDataAttribute("Thursday  January  03 2019", "Friday    January 04 2019", new string[0])]
        [Xunit.InlineDataAttribute("Friday    January  04 2019", "Saturday  January 05 2019", new string[0])]
        [Xunit.InlineDataAttribute("Saturday  January  05 2019", "Sunday    January 06 2019", new string[0])]
        [Xunit.InlineDataAttribute("Sunday    January  06 2019", "Monday    January 07 2019", new string[0])]
        public virtual void ScheduleAJobToRunTomorrowOutline(string currentDateAndTime, string dayOfWeekToRun, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Schedule a job to run tomorrow [outline]", null, exampleTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
    testRunner.Given(string.Format("today is {0}", currentDateAndTime), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
      testRunner.And("a job is configured to run tomorrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
     testRunner.When("scheduled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
     testRunner.Then(string.Format("it should run once sometime on the following {0}", dayOfWeekToRun), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Schedule a job to run tomorrow at a certain time")]
        [Xunit.TraitAttribute("FeatureTitle", "Next Day Scheduling")]
        [Xunit.TraitAttribute("Description", "Schedule a job to run tomorrow at a certain time")]
        public virtual void ScheduleAJobToRunTomorrowAtACertainTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Schedule a job to run tomorrow at a certain time", null, ((string[])(null)));
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 29
    testRunner.Given("a job is configured to run tomorrow at a given time", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
     testRunner.When("scheduled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
     testRunner.Then("it should run once at the specified time on the following day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Schedule a job to run tomorrow at a certain time [outline]")]
        [Xunit.TraitAttribute("FeatureTitle", "Next Day Scheduling")]
        [Xunit.TraitAttribute("Description", "Schedule a job to run tomorrow at a certain time [outline]")]
        [Xunit.InlineDataAttribute("Monday    December 31 2018 00:00", "Tuesday   January 01 2019 00:00", new string[0])]
        [Xunit.InlineDataAttribute("Tuesday   January  01 2019 02:15", "Wednesday January 02 2019 02:15", new string[0])]
        [Xunit.InlineDataAttribute("Wednesday January  02 2019 02:30", "Thursday  January 03 2019 02:30", new string[0])]
        [Xunit.InlineDataAttribute("Thursday  January  03 2019 04:45", "Friday    January 04 2019 04:45", new string[0])]
        [Xunit.InlineDataAttribute("Friday    January  04 2019 06:00", "Saturday  January 05 2019 06:00", new string[0])]
        [Xunit.InlineDataAttribute("Saturday  January  05 2019 10:15", "Sunday    January 06 2019 10:15", new string[0])]
        [Xunit.InlineDataAttribute("Sunday    January  06 2019 16:30", "Monday    January 07 2019 16:30", new string[0])]
        public virtual void ScheduleAJobToRunTomorrowAtACertainTimeOutline(string currentDateAndTime, string dateAndTimeToRun, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Schedule a job to run tomorrow at a certain time [outline]", null, exampleTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 34
    testRunner.Given(string.Format("today is {0}", currentDateAndTime), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
      testRunner.And("a job is configured to run tomorrow at time", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
     testRunner.When("scheduled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
     testRunner.Then(string.Format("it should run once the on {0}", dateAndTimeToRun), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                NextDaySchedulingFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                NextDaySchedulingFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion