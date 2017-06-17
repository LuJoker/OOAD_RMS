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
    public class UserMapProjectTests
    {
        User _user;
        Project _project;
        Tuple<User, Project> _ump;
        [TestInitialize()]
        public void UserMapProject()
        {
            _user = new User();
            _user.UserAccount = "admin";
            _user.UserPassword = "admin";
            _user.UserIdentity = "member";

            _project = new Project();
            _project.ProjectName = "pn";
            _project.ProjectDescription = "pd";
            
            _ump = new Tuple<User, Project>(_user, _project);
        }

        [TestMethod()]
        public void UserMapProjectTest_User()
        {
            Assert.AreEqual("admin", _ump.Item1.UserAccount);
            Assert.AreEqual("admin", _ump.Item1.UserPassword);
            Assert.AreEqual("member", _ump.Item1.UserIdentity);
        }

        [TestMethod()]
        public void UserMapProjectTest_Project()
        {
            Assert.AreEqual("pn", _ump.Item2.ProjectName);
            Assert.AreEqual("pd", _ump.Item2.ProjectDescription);
        }
    }
}