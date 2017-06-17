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
        [TestInitialize()]
        public void ProjectInit()
        {
            _project = new Project();
        }

        [TestMethod()]
        public void ProjectName()
        {
            _project.ProjectName = "test";
            Assert.AreEqual("test", _project.ProjectName);
        }

        [TestMethod()]
        public void ProjectDescription()
        {
            _project.ProjectDescription = "test123";
            Assert.AreEqual("test123", _project.ProjectDescription);
        }

    }
}