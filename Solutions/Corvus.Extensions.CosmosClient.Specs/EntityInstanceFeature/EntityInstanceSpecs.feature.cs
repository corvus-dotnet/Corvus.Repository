// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Corvus.Extensions.CosmosClient.Specs.EntityInstanceFeature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EntityInstance")]
    public partial class EntityInstanceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "EntityInstanceSpecs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EntityInstance", "\tIn order to obtain the ETag for stored entity instances\r\n\tAs a developer\r\n\tI wan" +
                    "t to be able to read a POCO written to a CosmosDB container as an EntityInstance" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize a POCO to a document with _etag and deserialize to an EntityInstance")]
        [NUnit.Framework.TestCaseAttribute("C79B34BA-20E8-4422-A6E5-5F03B1A062F5", "Henry", "1969-04-13", "01AFE3", null)]
        [NUnit.Framework.TestCaseAttribute("0C04904C-1679-4801-BA3C-2B92455B6533", "null", "1963-11-23", "null", null)]
        public virtual void SerializeAPOCOToADocumentWith_EtagAndDeserializeToAnEntityInstance(string id, string name, string dateOfBirth, string eTag, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize a POCO to a document with _etag and deserialize to an EntityInstance", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("I create a Person with Id \"{0}\", Name \"{1}\" and DateOfBirth \"{2}\" called \"SampleP" +
                            "erson\"", id, name, dateOfBirth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And(string.Format("I serialize the Person \"SamplePerson\" to a document called \"SampleDocument\" with " +
                            "ETag \"{0}\"", eTag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.When("I deserialize the document called \"SampleDocument\" to an EntityInstance called \"R" +
                        "esult\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then(string.Format("the EntityInstance called \"Result\" should have an Entity with Id \"{0}\", Name \"{1}" +
                            "\" and DateOfBirth \"{2}\" and an ETag \"{3}\"", id, name, dateOfBirth, eTag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Round-trip serialize an EntityInstance")]
        [NUnit.Framework.TestCaseAttribute("C79B34BA-20E8-4422-A6E5-5F03B1A062F5", "Henry", "1969-04-13", "01AFE3", null)]
        [NUnit.Framework.TestCaseAttribute("0C04904C-1679-4801-BA3C-2B92455B6533", "null", "1963-11-23", "null", null)]
        public virtual void Round_TripSerializeAnEntityInstance(string id, string name, string dateOfBirth, string eTag, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Round-trip serialize an EntityInstance", null, exampleTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 18
 testRunner.Given(string.Format("I create a Person with Id \"{0}\", Name \"{1}\" and DateOfBirth \"{2}\" called \"SampleP" +
                            "erson\"", id, name, dateOfBirth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 19
 testRunner.And(string.Format("I create an EntityInstance for the Person called \"SamplePerson\" with ETag \"{0}\" c" +
                            "alled \"SampleInstance\"", eTag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("I serialize the EntityInstance called \"SampleInstance\" to a document called \"Samp" +
                        "leDocument\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.When("I deserialize the document called \"SampleDocument\" to an EntityInstance called \"R" +
                        "esult\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then(string.Format("the EntityInstance called \"Result\" should have an Entity with Id \"{0}\", Name \"{1}" +
                            "\" and DateOfBirth \"{2}\" and an ETag \"{3}\"", id, name, dateOfBirth, eTag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Compare EntityInstances for equality")]
        [NUnit.Framework.TestCaseAttribute("C79B34BA-20E8-4422-A6E5-5F03B1A062F5", "Henry", "1969-04-13", "01AFE3", "C79B34BA-20E8-4422-A6E5-5F03B1A062F5", "Henry", "1969-04-13", "01AFE3", "true", null)]
        [NUnit.Framework.TestCaseAttribute("0C04904C-1679-4801-BA3C-2B92455B6533", "null", "1963-11-23", "null", "0C04904C-1679-4801-BA3C-2B92455B6533", "null", "1963-11-23", "null", "true", null)]
        [NUnit.Framework.TestCaseAttribute("6C781E3A-EC13-40BD-83B6-B3DFD7B478A5", "Henry", "1963-11-23", "null", "6C781E3A-EC13-40BD-83B6-B3DFD7B478A5", "null", "1963-11-23", "null", "false", null)]
        [NUnit.Framework.TestCaseAttribute("0874114E-6A73-467A-843A-67CF92B0916E", "null", "1963-11-23", "null", "0874114E-6A73-467A-843A-67CF92B0916E", "Henry", "1963-11-23", "null", "false", null)]
        [NUnit.Framework.TestCaseAttribute("C9E51AB5-D027-43B4-9CAE-2D0D1AB67FB8", "Henry", "1963-11-23", "01AFE3", "C9E51AB5-D027-43B4-9CAE-2D0D1AB67FB8", "Henry", "1963-11-23", "null", "false", null)]
        [NUnit.Framework.TestCaseAttribute("26952722-08AB-4351-AA55-5EDEF780761A", "Henry", "1963-11-23", "null", "26952722-08AB-4351-AA55-5EDEF780761A", "Henry", "1963-11-23", "01AFE3", "false", null)]
        [NUnit.Framework.TestCaseAttribute("62CEF04D-026F-40AD-B4D2-0E3BE5D9A1C7", "Henry", "1971-04-22", "01AFE3", "62CEF04D-026F-40AD-B4D2-0E3BE5D9A1C7", "Henry", "1969-04-13", "01AFE3", "false", null)]
        public virtual void CompareEntityInstancesForEquality(string leftId, string leftName, string leftDateOfBirth, string leftETag, string rightId, string rightName, string rightDateOfBirth, string rightETag, string equal, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare EntityInstances for equality", null, exampleTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
 testRunner.Given(string.Format("I create a Person with Id \"{0}\", Name \"{1}\" and DateOfBirth \"{2}\" called \"SampleP" +
                            "ersonLeft\"", leftId, leftName, leftDateOfBirth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 31
 testRunner.Given(string.Format("I create a Person with Id \"{0}\", Name \"{1}\" and DateOfBirth \"{2}\" called \"SampleP" +
                            "ersonRight\"", rightId, rightName, rightDateOfBirth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.And(string.Format("I create an EntityInstance for the Person called \"SamplePersonLeft\" with ETag \"{0" +
                            "}\" called \"LeftInstance\"", leftETag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And(string.Format("I create an EntityInstance for the Person called \"SamplePersonRight\" with ETag \"{" +
                            "0}\" called \"RightInstance\"", rightETag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then(string.Format("the Equals comparison of the EntityInstance called \"LeftInstance\" with the Entity" +
                            "Instance called \"RightInstance\" should be \"{0}\"", equal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.And(string.Format("the Equals comparison of the EntityInstance called \"LeftInstance\" with the Entity" +
                            "Instance called \"RightInstance\" as an object should be \"{0}\"", equal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("the Equals comparison of the EntityInstance called \"LeftInstance\" with a null Ent" +
                        "ityInstance should be \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the Equals comparison of the EntityInstance called \"LeftInstance\" with a null obj" +
                        "ect should be \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And(string.Format("the == comparison of the EntityInstance called \"LeftInstance\" with the EntityInst" +
                            "ance called \"RightInstance\" should be \"{0}\"", equal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And(string.Format("the != comparison of the EntityInstance called \"LeftInstance\" with the EntityInst" +
                            "ance called \"RightInstance\" should be not \"{0}\"", equal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
