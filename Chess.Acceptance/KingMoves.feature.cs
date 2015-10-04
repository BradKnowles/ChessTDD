﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Chess.Acceptance
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class KingMovementFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "KingMoves.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "King movement", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "King movement")))
            {
                Chess.Acceptance.KingMovementFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A king in its beginning position")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "King movement")]
        public virtual void AKingInItsBeginningPosition()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A king in its beginning position", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "BK",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP"});
            table1.AddRow(new string[] {
                        "WR",
                        "WKn",
                        "WB",
                        "WQ",
                        "WK",
                        "WB",
                        "WKn",
                        "WR"});
#line 4
  testRunner.When("there is a chess board set up as", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
#line 15
  testRunner.Then("the piece at (5,1) should have exactly the following moves", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A king with no pawn in front")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "King movement")]
        public virtual void AKingWithNoPawnInFront()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A king with no pawn in front", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "BQ",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "",
                        "WP",
                        "WP",
                        "WP"});
            table3.AddRow(new string[] {
                        "WR",
                        "WKn",
                        "WB",
                        "WQ",
                        "WK",
                        "WB",
                        "WKn",
                        "WR"});
#line 19
  testRunner.When("there is a chess board set up as", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
            table4.AddRow(new string[] {
                        "5",
                        "2"});
#line 30
  testRunner.Then("the piece at (5,1) should have exactly the following moves", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("King with nothing around")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "King movement")]
        public virtual void KingWithNothingAround()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("King with nothing around", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table5.AddRow(new string[] {
                        "BR",
                        "",
                        "",
                        "",
                        "BK",
                        "",
                        "",
                        "BR"});
            table5.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "",
                        "WP",
                        "WP",
                        "WP"});
            table5.AddRow(new string[] {
                        "WR",
                        "WKn",
                        "WB",
                        "WQ",
                        "WK",
                        "WB",
                        "WKn",
                        "WR"});
#line 35
  testRunner.When("there is a chess board set up as", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
            table6.AddRow(new string[] {
                        "4",
                        "8"});
            table6.AddRow(new string[] {
                        "4",
                        "7"});
            table6.AddRow(new string[] {
                        "5",
                        "7"});
            table6.AddRow(new string[] {
                        "6",
                        "7"});
            table6.AddRow(new string[] {
                        "6",
                        "8"});
            table6.AddRow(new string[] {
                        "7",
                        "8"});
            table6.AddRow(new string[] {
                        "3",
                        "8"});
#line 46
  testRunner.Then("the piece at (5,8) should have exactly the following moves", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A king eligible to castle")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "King movement")]
        public virtual void AKingEligibleToCastle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A king eligible to castle", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "WR",
                        "",
                        "",
                        "",
                        "WK",
                        "",
                        "",
                        "WR"});
#line 57
 testRunner.When("there is a chess board set up as", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
            table8.AddRow(new string[] {
                        "4",
                        "1"});
            table8.AddRow(new string[] {
                        "4",
                        "2"});
            table8.AddRow(new string[] {
                        "5",
                        "2"});
            table8.AddRow(new string[] {
                        "6",
                        "2"});
            table8.AddRow(new string[] {
                        "6",
                        "1"});
            table8.AddRow(new string[] {
                        "7",
                        "1"});
            table8.AddRow(new string[] {
                        "3",
                        "1"});
#line 67
 testRunner.Then("the piece at (5,1) should have exactly the following moves", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
