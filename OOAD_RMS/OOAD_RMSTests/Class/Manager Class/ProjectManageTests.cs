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
    public class ProjectManageTests
    {
        ProjectManager _pm;
        List<User> _users;
        Project _project;
        User _admin;
        User _member;
        [TestInitialize()]
        public void ProjectManageTestsInit()
        {
            _pm = new ProjectManager();

            _project = new Project();
            _project.ProjectName = "pn";
            _project.ProjectDescription = "pd";

            _admin = new User();
            _admin.UserAccount = "admin";
            _admin.UserIdentity = "admin";
            _admin.UserPassword = "admin";

            _member = new User();
            _member.UserAccount = "Jeff";
            _member.UserIdentity = "member";
            _member.UserPassword = "123";

            _users = new List<User>();
            _users.Add(_admin);
            _users.Add(_member);

        }

        [TestMethod()]
        public void addProjectForSingleUserTest()    //使用者新增專案
        {
            List<Project> projectList = new List<Project>();
            _pm.addProject(_admin, _project);
            projectList = _pm.GetProjects(_admin);
            Assert.AreEqual("pn", projectList.Find(x => x.ProjectName == "pn").ProjectName);
            Assert.AreEqual("pd", projectList.Find(x => x.ProjectName == "pn").ProjectDescription);
        }

        [TestMethod()]
        public void addProjectForAddedUsersTest()    //project底下新增的成員
        {
            List<User> userList = new List<User>();
            _pm.addProject(_project, _users);
            userList = _pm.GetProjectMapUsers(_project);
            Assert.AreEqual("admin", userList.Find(x => x.UserAccount == "admin").UserAccount);
            Assert.AreEqual("Jeff", userList.Find(x => x.UserAccount == "Jeff").UserAccount);

        }

        [TestMethod()]
        public void editProjectTest()
        {
            List<User> userList = new List<User>();
            _project.ProjectName = "editpn";
            _project.ProjectDescription = "editpd";
            _pm.editProject(_project, _users);
            userList = _pm.GetProjectMapUsers(_project);
            Assert.AreEqual("admin", userList.Find(x => x.UserAccount == "admin").UserAccount);
            Assert.AreEqual("Jeff", userList.Find(x => x.UserAccount == "Jeff").UserAccount);
        }

        [TestMethod()]
        public void deleteProjectTest()
        {
            List<Project> projectList = new List<Project>();
            _pm.deleteProject(_project);
            projectList = _pm.GetProjects(_admin);
            Assert.AreEqual(0, projectList.Count);
        }

        [TestMethod()]
        public void GetProjectMapUsersTest()
        {
            List<User> userList = new List<User>();
            _pm.addProject(_project, _users);
            userList = _pm.GetProjectMapUsers(_project);
            Assert.AreEqual("admin", userList.Find(x => x.UserAccount == "admin").UserAccount);
            Assert.AreEqual("Jeff", userList.Find(x => x.UserAccount == "Jeff").UserAccount);

        }

        [TestMethod()]
        public void GetProjectsTest()
        {
            List<Project> projectList = new List<Project>();
            _pm.addProject(_admin, _project);
            projectList = _pm.GetProjects(_admin);
            Assert.AreEqual("pn", projectList.Find(x => x.ProjectName == "pn").ProjectName);
            Assert.AreEqual("pd", projectList.Find(x => x.ProjectName == "pn").ProjectDescription);
        }
    }
}