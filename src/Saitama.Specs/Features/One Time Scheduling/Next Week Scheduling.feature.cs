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
    public partial class NextWeekSchedulingFeature : Xunit.IClassFixture<NextWeekSchedulingFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Next Week Scheduling.feature"
#line hidden
        
        public NextWeekSchedulingFeature(NextWeekSchedulingFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Next Week Scheduling", @"     As a automation enthusiast
     I would like to be able to run tasks once on specific moments
     So that i am able run tasks like user feedback request after a month of registration,
     trial period complete notifications, Anniversary notifications, e-mail dispatch e.t.c", ProgrammingLanguage.CSharp, new string[] {
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
        
        [Xunit.TheoryAttribute(DisplayName="Schedule a job to run next week on specific weekday")]
        [Xunit.TraitAttribute("FeatureTitle", "Next Week Scheduling")]
        [Xunit.TraitAttribute("Description", "Schedule a job to run next week on specific weekday")]
        [Xunit.InlineDataAttribute("2019-01-01T00:00:00.0+00:00", "Monday", "6.00:00:00", new string[0])]
        [Xunit.InlineDataAttribute("2019-01-01T00:00:00.0+00:00", "Tuesday", "7.00:00:00", new string[0])]
        [Xunit.InlineDataAttribute("2019-01-01T00:00:00.0+00:00", "Wednesday", "8.00:00:00", new string[0])]
        [Xunit.InlineDataAttribute("2019-01-01T00:00:00.0+00:00", "Thursday", "9.00:00:00", new string[0])]
        [Xunit.InlineDataAttribute("2019-01-01T00:00:00.0+00:00", "Friday", "10.00:00:00", new string[0])]
        [Xunit.InlineDataAttribute("2019-01-01T00:00:00.0+00:00", "Saturday", "11.00:00:00", new string[0])]
        [Xunit.InlineDataAttribute("2019-01-01T00:00:00.0+00:00", "Sunday", "12.00:00:00", new string[0])]
        public virtual void ScheduleAJobToRunNextWeekOnSpecificWeekday(string current_Date_And_Time, string day_Of_Week, string time_To_Execution, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Schedule a job to run next week on specific weekday", null, exampleTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
    testRunner.Given(string.Format("the current date and time are \"{0}\"", current_Date_And_Time), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
      testRunner.And(string.Format("a job is configured to run next week {0}", day_Of_Week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
     testRunner.When("scheduled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
     testRunner.Then(string.Format("it should run once after \"{0}\"", time_To_Execution), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                NextWeekSchedulingFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                NextWeekSchedulingFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion