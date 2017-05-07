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
    public class ModelTests
    {
        Model _model;
        [TestInitialize()]
        public void ModelInitialize()
        {
            string _projectName = "test_ProjectName";
            string _projectDescription = "test_ProjectDescription";
            _model = new Model();
        }
        [TestMethod()]
        public void ModelTest()
        {
            Assert.IsTrue(_model.LoginCheck("admin","admin"));
        }

        [TestMethod()]
        public void addProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void editProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getRequirementFromSelectProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getTestFromSelectProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void addRequirementTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void editRequirementTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteRequirementTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void addTestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginCheckTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetProjectsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRequirementTest()
        {
            Assert.Fail();
        }
    }
}