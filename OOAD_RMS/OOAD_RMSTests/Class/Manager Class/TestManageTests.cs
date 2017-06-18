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
    public class TestManageTests
    {
        TestManager _tm;
        List<Requirement> _requirements;
        Requirement _requirement1, _requirement2;
        Test _test;
        Project _project;
        bool _isComplete;
        [TestInitialize()]
        public void TestManageTestsInit()
        {
            _tm = new TestManager();
            _isComplete = false;

            _project = new Project();
            _project.ProjectName = "pn";
            _project.ProjectDescription = "pd";

            _requirement1 = new Requirement();
            _requirement1.RequirementDescription = "rd";
            _requirement1.RequirementName = "rn";
            _requirement1.Project = _project;

            _requirement2 = new Requirement();
            _requirement2.RequirementDescription = "rd2";
            _requirement2.RequirementName = "rn2";
            _requirement2.Project = _project;

            _test = new Test();
            _test.TestName = "tn";
            _test.TestDescription = "td";
            _test.Project = _project;

            _requirements = new List<Requirement>();
            _requirements.Add(_requirement1);
            _requirements.Add(_requirement2);
        }

        [TestMethod()]
        public void addTestForSingleUserTest()   // user新增測試
        {
            List<Test> testList;
            _tm.addTest(_test, _requirement1, _isComplete);
            testList = _tm.GetTests(_project);
            Assert.AreEqual("tn", testList.Find(x => x.TestName == "tn").TestName);
        }

        [TestMethod()]
        public void addTestForAddedRequirementTest()  //Requirement底下新增測試
        {
            List<Requirement>requirementList;
            _tm.addTest(_test, _requirements);
            requirementList = _tm.GetTestMapRequirements(_test,_project);
            Assert.AreEqual("rn", requirementList.Find(x => x.RequirementName == "rn").RequirementName);
            Assert.AreEqual("rn2", requirementList.Find(x => x.RequirementName == "rn2").RequirementName);
        }

        [TestMethod()]
        public void editTestTest()
        {
            List<Test> testList;
            _test.TestName = "edittn";
            _test.TestDescription = "edittd";
            _tm.editTest(_test, _requirements);
            testList = _tm.GetTests(_project);
            Assert.AreEqual("edittn", testList[0].TestName);
            Assert.AreEqual("edittd", testList[0].TestDescription);
        }

        [TestMethod()]
        public void deleteTestTest()
        {
            List<Test> testList;
            _tm.deleteTest(_test);
            testList = _tm.GetTests(_project);
            Assert.AreEqual(0, testList.Count);
        }

        [TestMethod()]
        public void getTestMapRequirementIsCompleteTest()
        {
            _tm.addTest(_test, _requirement1,false);
            Assert.AreEqual(false, _tm.getTestMapRequirementIsComplete(_test, _requirement1));
        }

        [TestMethod()]
        public void updateTestMapRequirementIsCompleteTest()
        {
            _tm.addTest(_test, _requirement1, false);
            _tm.updateTestMapRequirementIsComplete(_test, _requirement1, true);
            Assert.AreEqual(true, _tm.getTestMapRequirementIsComplete(_test, _requirement1));
        }

        [TestMethod()]
        public void GetTestMapRequirementsTest()
        {
            List<Requirement> requirementList;
            _tm.addTest(_test, _requirements);
            requirementList = _tm.GetTestMapRequirements(_test, _project);
            Assert.AreEqual("rn", requirementList.Find(x => x.RequirementName == "rn").RequirementName);
            Assert.AreEqual("rn2", requirementList.Find(x => x.RequirementName == "rn2").RequirementName);
        }

        [TestMethod()]
        public void GetTestsTest()
        {
            List<Test> testList;
            _tm.addTest(_test, _requirement1, false);
            testList = _tm.GetTests(_project);
            Assert.AreEqual("tn", testList[0].TestName);
        }

        [TestMethod()]
        public void GetTestMapRequirementTest()
        {
            List<TestMapRequirement> tmp;
            _tm.addTest(_test, _requirement1, false);
            tmp = _tm.GetTestMapRequirement();
            Assert.AreEqual("tn", tmp[0].Test.TestName);
            Assert.AreEqual("rn", tmp[0].Requirement.RequirementName);
        }
    }
}