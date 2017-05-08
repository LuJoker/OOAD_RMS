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
    public class UserTests
    {
        List<Project> _inProjects;
        User _user;
        [TestInitialize()]
        public void TestInit()
        {
            _user = new User();
            _inProjects = new List<Project>();
        }

        [TestMethod()]
        public void addProjectTest()
        {
            Project pro = new Project();
            pro.ProjectName = "pro_name";
            pro.ProjectDescription = "pro_description";
            _user.addProject(pro);
            Assert.AreEqual("pro_name", _user.GetInProjects()[0].ProjectName);
            Assert.AreEqual("pro_description", _user.GetInProjects()[0].ProjectDescription);
        }

        [TestMethod()]
        public void GetInProjectsTest()
        {
            Project pro = new Project();
            pro.ProjectName = "pro_name";
            pro.ProjectDescription = "pro_description";
            _user.addProject(pro);
            Assert.AreEqual(1, _user.GetInProjects().Count);
        }
    }
}