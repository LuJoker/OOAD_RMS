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
    public class TestTest
    {
        Test _test;
        [TestInitialize()]
        public void TestInit()
        {
            _test = new Test();
            _test.Project = new Project();
        }

        [TestMethod()]
        public void Test_RequirementName()
        {
            _test.TestName = "test";
            Assert.AreEqual("test", _test.TestName);
        }

        [TestMethod()]
        public void Test_RequirementDescription()
        {
            _test.TestDescription= "test123";
            Assert.AreEqual("test123", _test.TestDescription);
        }

        [TestMethod()]
        public void Test_ProjectName()
        {
            _test.Project.ProjectName = "testProject";
            Assert.AreEqual("testProject", _test.Project.ProjectName);
        }

        [TestMethod()]
        public void Test_ProjectDescription()
        {
            _test.Project.ProjectDescription = "testProjectDescription";
            Assert.AreEqual("testProjectDescription", _test.Project.ProjectDescription);
        }

    }
}
