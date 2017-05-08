using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOAD_RMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_RMS.Tests
{
    [TestClass()]
    public class ProjectTests
    {
        Project _project;
        private string _projectName;
        private string _projectDescription;
        private List<Requirement> _requirements;
        private List<Test> _tests;
        [TestInitialize()]
        public void ProjectInit()
        {
            _project = new Project();
            _requirements = new List<Requirement>();
            _tests = new List<Test>();
        }

        [TestMethod()]
        public void AddRequirementTest()
        {
            Requirement re1 = new Requirement();
            re1.RequirementName = "re1_name";
            re1.RequirementDescription = "re1_description";
            _project.AddRequirement(re1);
            Assert.AreEqual("re1_name", _project.GetRequirements()[0].RequirementName);
            Assert.AreEqual("re1_description", _project.GetRequirements()[0].RequirementDescription);
        }

        [TestMethod()]
        public void AddTestTest()
        {
            Test test1 = new Test();
            test1.testName = "test_name";
            test1.testDescription = "test_description";
            _project.AddTest(test1);
            Assert.AreEqual("test_name",_project.GetTests()[0].testName);
            Assert.AreEqual("test_description", _project.GetTests()[0].testDescription);
        }

        [TestMethod()]
        public void GetRequirementsTest()
        {
            Requirement re1 = new Requirement();
            re1.RequirementName = "re1_name";
            re1.RequirementDescription = "re1_description";
            _project.AddRequirement(re1);
            Assert.AreEqual(1, _project.GetRequirements().Count);
        }

        [TestMethod()]
        public void GetTestsTest()
        {
            Test test1 = new Test();
            test1.testName = "test_name";
            test1.testDescription = "test_description";
            _project.AddTest(test1);
            Assert.AreEqual(1, _project.GetTests().Count);
        }
    }
}