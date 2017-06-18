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
    public class UserManagerTests
    {
        UserManager _um;
        User _admin;
        User _member;
        [TestInitialize()]
        public void UserManagerTestsInit()
        {
            _um = new UserManager();

            _admin = new User();
            _admin.UserAccount = "admin";
            _admin.UserIdentity = "admin";
            _admin.UserPassword = "admin";

            _member = new User();
            _member.UserAccount = "Jeff";
            _member.UserIdentity = "member";
            _member.UserPassword = "123";
        }

        [TestMethod()]
        public void addUserTest()
        {
            _um.addUser(_admin);
            User user = _um.getUser("admin", "admin");
            Assert.AreEqual("admin", user.UserAccount);
        }

        [TestMethod()]
        public void getUserTest()
        {
            _um.addUser(_admin);
            User user = _um.getUser("admin", "admin");
            Assert.AreEqual("admin", user.UserAccount);
        }

        [TestMethod()]
        public void GetUsersTest()
        {
            List<User> userList;
            _um.addUser(_admin);
            _um.addUser(_member);
            userList = _um.GetUsers();
            Assert.AreEqual("admin", userList[0].UserAccount);
            Assert.AreEqual("Jeff", userList[1].UserAccount);
        }

        //[TestMethod()]
        //public void LoginCheckTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void registerAccountTest()
        //{
        //    Assert.Fail();
        //}
    }
}